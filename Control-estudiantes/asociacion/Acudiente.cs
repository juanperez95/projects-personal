using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    public class Acudiente : Usuario
    {
        private string correo;
        public string Correo { get => correo; set => correo = value; }

        public Acudiente(string correo = "")
        {
            this.correo = correo;
        }

        public DataTable ConsultarAvance(SqlConnection conexion, int acudiente,int opcion, DateTime fecha = new DateTime())
        {
            DataTable tabla = new DataTable();
            if (opcion == 1)
            {
                SqlCommand cmd = new SqlCommand(@"select registro from child where idAcudiente = @acudiente", conexion);
                cmd.Parameters.AddWithValue("@acudiente", acudiente);
                SqlDataReader data = cmd.ExecuteReader();
                data.Read();
                try
                {
                    SqlCommand comando = new SqlCommand(@"select * from avance_academico where idChild = @id", conexion);
                    comando.Parameters.AddWithValue("@id", int.Parse(data["registro"].ToString()));
                    data.Close();
                    SqlDataAdapter datosTabla = new SqlDataAdapter(comando);
                    datosTabla.Fill(tabla);
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("¡No se encontraron avances del Niñ@, relacionados con el acudiente!" + e, "Notificacion", System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            else
            {
                SqlCommand comando = new SqlCommand(@"select * from avance_academico where idChild = @id and fechaEntregaNotas = @fecha", conexion);
                comando.Parameters.AddWithValue("@id",acudiente);
                comando.Parameters.AddWithValue("@fecha", fecha);
                SqlDataAdapter datosTabla = new SqlDataAdapter(comando);
                datosTabla.Fill(tabla);
            }
            
            
            return tabla;
        }
    }
}
