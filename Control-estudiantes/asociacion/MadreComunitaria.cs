using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asociacion
{
    public class MadreComunitaria : Usuario
    {
        public MadreComunitaria()
        {
        }

        public int Validaciones(SqlConnection conexion)
        {
            SqlCommand cmd = new SqlCommand("select idMadre from madre_comunitaria where idMadre = @id", conexion);
            cmd.Parameters.AddWithValue("@id", this.identificacion);
            SqlDataReader objeto = cmd.ExecuteReader();
            objeto.Read();
            try
            {
                if (int.Parse(objeto["idMadre"].ToString()) == this.identificacion)
                {
                    objeto.Close();
                    return 1;
                }
            }
            catch (Exception)
            {
            }
            objeto.Close();
            return 0;
        }

        public void RegistrarAsistencia(SqlConnection conexion,int idChild ,DateTime fecha, String descripcion)
        {
            
            string f = fecha.ToString("yyyy-MM-dd");
            Console.WriteLine(fecha.ToString());
            Asistencia asistencia = new Asistencia(fecha,descripcion);

            // Composicion de Asistencia y clase Madre -------------------------------------------------------------------------
            switch (asistencia.ValidarAsistencia())
            {
                case 0:
                    System.Windows.Forms.MessageBox.Show("¡Fuera de horario, para llenar la asistencia!",
                        "Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                    break;
                case 1: // Si el niño esta enfermo.
                    SqlCommand cmd = new SqlCommand(@"insert into asistencia values(@idChild,@fecha,@desc)", conexion);
                    cmd.Parameters.AddWithValue("@idChild", idChild);
                    cmd.Parameters.AddWithValue("@fecha", f);
                    cmd.Parameters.AddWithValue("@desc", descripcion);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("¡El niñ@ se encuentra ENFERMO, se notifica al Administrador, sin embargo el registro se realizo!",
                        "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                    break;
                case 2: // Si todo la validacion cumple.
                    cmd = new SqlCommand(@"insert into asistencia values(@idChild,@fecha,@desc)",conexion);                    
                    cmd.Parameters.AddWithValue("@idChild",idChild);
                    cmd.Parameters.AddWithValue("@fecha",f);
                    cmd.Parameters.AddWithValue("@desc", descripcion);
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("¡Asistencia, validada!",
                        "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    break;
            }
            

        }

        public DataTable ViewAsistenciaAndAvance(SqlConnection conexion, int opcion, int id = 0, DateTime fechaFiltro = new DateTime())
        {
            DataTable tabla = new DataTable();
            switch (opcion)
            {
                case 1:                    
                    SqlCommand comando = new SqlCommand("select idChild as 'ID Niño', fecha, descripcion from asistencia", conexion);
                    SqlDataAdapter forma = new SqlDataAdapter(comando);
                    forma.Fill(tabla);
                    break;
                case 2:
                    comando = new SqlCommand("select * from avance_academico", conexion);
                    forma = new SqlDataAdapter(comando);
                    forma.Fill(tabla);
                    break;
                case 3:
                    comando = new SqlCommand(@"select * from asistencia where idChild = @id and fecha = @fecha", conexion);
                    comando.Parameters.AddWithValue("@id",id);
                    comando.Parameters.AddWithValue("@fecha", fechaFiltro);
                    forma = new SqlDataAdapter(comando);
                    forma.Fill(tabla);
                    break;
                case 4:
                    comando = new SqlCommand(@"select * from avance_academico where idChild = @id and fechaEntregaNotas = @fecha", conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@fecha", fechaFiltro);
                    forma = new SqlDataAdapter(comando);
                    forma.Fill(tabla);
                    break;
            }
            return tabla;

        }
    }
}
