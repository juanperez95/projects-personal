using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    public class Child : Usuario
    {
        private string tipoSangre, EPS, ciudadNacimiento;

        private int idAcudiente, idJardin;

        public string TipoSangre { get => tipoSangre; set => tipoSangre = value; }
        public string EPS1 { get => EPS; set => EPS = value; }
        public string CiudadNacimiento { get => ciudadNacimiento; set => ciudadNacimiento = value; }
        public int IdAcudiente { get => idAcudiente; set => idAcudiente = value; }
        public int IdJardin { get => idJardin; set => idJardin = value; }

        public Child(string tipoSangre = "", string ePS = "", string ciudadNacimiento = "")
        {
            this.tipoSangre = tipoSangre;
            EPS = ePS;
            this.ciudadNacimiento = ciudadNacimiento;
        }

        public void ValidarCumpleanos(SqlConnection conexion)
        {
            
            DateTime fechaActual = DateTime.Today;
            SqlCommand cmd = new SqlCommand(@"select FechaNacimiento from child where registro = @documento",conexion);
            cmd.Parameters.AddWithValue("@documento", this.identificacion);
            SqlDataReader objeto = cmd.ExecuteReader();

            objeto.Read();
            try
            {
                DateTime fechaBaseDatos = Convert.ToDateTime(objeto["fechaNacimiento"].ToString());
                int edad = fechaActual.Year - fechaBaseDatos.Year;
                objeto.Close();
                if (edad == 5) // Validar si el niño ya tiene 5 años para ser trasladado.
                    System.Windows.Forms.MessageBox.Show("El niño debe ser trasladado el siguiente año al colegio.", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                else if(fechaBaseDatos.Day == fechaActual.Day && fechaBaseDatos.Month == fechaActual.Month) // Validar si cumple años el niño
                        System.Windows.Forms.MessageBox.Show($"¡La asociacion le desea un feliz cumpleaños a {this.nombres}!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                objeto.Close();
            }
            
        }

        public void GenerarNotas(SqlConnection conexion,int id, string year, string nivel, string notas, string desc, DateTime fecha)
        {
            SqlCommand comando = new SqlCommand(@"insert into avance_academico values(@idChild,@yearEscolar,@nivel,@notas,@descripcion,@fecha)",conexion);
            comando.Parameters.AddWithValue("@idChild",id);
            comando.Parameters.AddWithValue("@yearEscolar", year);
            comando.Parameters.AddWithValue("@nivel", nivel);
            comando.Parameters.AddWithValue("@notas", notas);
            comando.Parameters.AddWithValue("@descripcion", desc);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("¡Avance registrado exitosamente!.", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK,
                       System.Windows.Forms.MessageBoxIcon.Information);
        }


        public int Validaciones(SqlConnection conexion)
        {
            DateTime fecha = DateTime.Today;
            int edad = fecha.Year - this.fechaNacimiento.Year;

            SqlCommand cmd = new SqlCommand(@"select * from child where registro = @id", conexion);
            cmd.Parameters.AddWithValue("@id", this.identificacion);
            SqlDataReader objeto = cmd.ExecuteReader();
            objeto.Read();
            try
            {
                if (int.Parse(objeto["registro"].ToString()) == this.identificacion)
                {
                    objeto.Close();
                    return 1; // Validar si existe en la base de datos.
                }             
            }
            catch (Exception)
            {
            }

            if (edad > 6) // Validar la edad del niño 
            {
                objeto.Close();
                return 2;
            }

            objeto.Close();
            return 0;
        }
    }
}
