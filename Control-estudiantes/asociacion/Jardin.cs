using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    public class Jardin
    {
        private int idJardin;
        private string nombreJardin, direccion, estado;

        public int IdJardin { get => idJardin; set => idJardin = value; }
        public string NombreJardin { get => nombreJardin; set => nombreJardin = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Estado { get => estado; set => estado = value; }

        public Jardin(int idJardin = 0, string nombreJardin = "", string direccion = "", string estado = "")
        {
            this.idJardin = idJardin;
            this.nombreJardin = nombreJardin;
            this.direccion = direccion;
            this.estado = estado;
        }

        public int Validaciones(SqlConnection conexion)
        {
            // Validar si existe el jardin
            SqlCommand cmd = new SqlCommand(@"select idJardin, nombreJardin from jardin where idJardin = @id or nombreJardin = @nombre",conexion);
            cmd.Parameters.AddWithValue("@id",this.idJardin);
            cmd.Parameters.AddWithValue("@nombre", this.nombreJardin);
            SqlDataReader objeto = cmd.ExecuteReader();
            objeto.Read();
            try
            {
                if (this.idJardin == int.Parse(objeto["idJardin"].ToString()) || this.nombreJardin == objeto["nombreJardin"].ToString())
                    objeto.Close();
                    return 1;
            }
            catch (Exception)
            {
            }
            objeto.Close();
            return 0;
        }
    }
}
