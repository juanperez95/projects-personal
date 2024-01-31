using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asociacion;

namespace LogIn
{
    public class Login
    {
        private int documento;
        private SqlConnection conexion = new SqlConnection("server=localhost; database=asociacion; integrated security=true");

        public int Documento { get => documento; set => documento = value; }
        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public Login(int documento)
        {
            this.documento = documento;
        }

        public List<int> BuscarObjetos(string sentencias, int position = 0)
        {
            List<int> listaDatos = new List<int>();
            this.conexion.Open();
            SqlCommand comando = new SqlCommand(sentencias,this.conexion);
            SqlDataReader data = comando.ExecuteReader();
            while (data.Read())
                listaDatos.Add(data.GetInt32(position));
            this.conexion.Close();
            return listaDatos;
        }


        // Metodos para traer los datos al formulario.
        public Child ObjetoBoy(int id)
        {
            SqlCommand comando; // Traer objetos para actualizar los campos de los usuarios y jardines.
            this.conexion.Open();
            Child chico = new Child();
            comando = new SqlCommand(@"select * from child where registro = @id",this.conexion);
            comando.Parameters.AddWithValue("@id",id);
            SqlDataReader data = comando.ExecuteReader();
            try
            {
                data.Read();
                chico.Telefono = data["telefono"].ToString();
                chico.Nombres = data["nombres"].ToString();
                chico.TipoSangre = data["tipoSangre"].ToString();
                chico.Identificacion = int.Parse(data["registro"].ToString());
                chico.CiudadNacimiento = data["ciudadNacimiento"].ToString();
                chico.Direccion = data["direccion"].ToString();
                chico.EPS1 = data["eps"].ToString();
                chico.FechaNacimiento = Convert.ToDateTime(data["fechaNacimiento"].ToString());
                chico.IdAcudiente = int.Parse(data["idAcudiente"].ToString());
                chico.IdJardin = int.Parse(data["idJardin"].ToString());
                data.Close();
                this.conexion.Close();
            }
            catch (Exception)
            {
                chico.Telefono = "";
                chico.Nombres = "";
                chico.TipoSangre = "";
                chico.Identificacion = 0;
                chico.CiudadNacimiento = "";
                chico.Direccion = "";
                chico.EPS1 = "";
                chico.FechaNacimiento = new DateTime(1995,1,1);
                chico.IdAcudiente = 0;
                chico.IdJardin = 0;
            }
            
            return chico;

        }

        public Jardin ObjetoJardin(int id)
        {
            SqlCommand comando; // Traer objetos para actualizar los campos de los usuarios y jardines.
            this.conexion.Open();
            Jardin jardin = new Jardin();
            comando = new SqlCommand(@"select * from jardin where idJardin = @id", this.conexion);
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader data = comando.ExecuteReader();
            try
            {
                data.Read();
                jardin.Direccion = data["direccion"].ToString();
                jardin.Estado = data["estado"].ToString();
                jardin.IdJardin = int.Parse(data["idJardin"].ToString());
                jardin.NombreJardin = data["nombreJardin"].ToString();

                data.Close();
                this.conexion.Close();
            }
            catch (Exception)
            {
                jardin.Direccion = "";
                jardin.Estado = "";
                jardin.IdJardin = 0;
                jardin.NombreJardin = "";

            }

            return jardin;

        }

        public Acudiente ObjetoAcudiente(int id)
        {
            SqlCommand comando; // Traer objetos para actualizar los campos de los usuarios y jardines.
            this.conexion.Open();
            Acudiente acudiente = new Acudiente();
            comando = new SqlCommand(@"select * from acudiente where documento = @id", this.conexion);
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader data = comando.ExecuteReader();
            try
            {
                data.Read();
                acudiente.Direccion = data["direccion"].ToString();
                acudiente.Correo = data["correo"].ToString();
                acudiente.Identificacion = int.Parse(data["documento"].ToString());
                acudiente.Nombres = data["nombre"].ToString();
                acudiente.Telefono = data["telefono"].ToString();

                data.Close();
                this.conexion.Close();
            }
            catch (Exception)
            {
                acudiente.Direccion = "";
                acudiente.Correo = "";
                acudiente.Identificacion = 0;
                acudiente.Nombres = "";
                acudiente.Telefono = "";


            }

            return acudiente;
        }

        public MadreComunitaria ObjetoMother(int id)
        {
            SqlCommand comando; // Traer objetos para actualizar los campos de los usuarios y jardines.
            this.conexion.Open();
            MadreComunitaria mother = new MadreComunitaria();
            comando = new SqlCommand(@"select * from madre_comunitaria where idMadre = @id", this.conexion);
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader data = comando.ExecuteReader();
            try
            {
                data.Read();
                mother.Direccion = data["direccionResidencia"].ToString();
                mother.FechaNacimiento = Convert.ToDateTime(data["fechaNacimiento"].ToString());
                mother.Identificacion = int.Parse(data["idMadre"].ToString());
                mother.Nombres = data["nombres"].ToString();
                mother.Telefono = data["telefono"].ToString();


                data.Close();
                this.conexion.Close();
            }
            catch (Exception)
            {
                mother.Direccion = "";
                mother.FechaNacimiento = new DateTime(1995,1,1);
                mother.Identificacion = 0;
                mother.Nombres = "";
                mother.Telefono = "";

            }

            return mother;
        }

        // Validar las credenciales.
        public int validarLogin(string rol)
        {
            SqlCommand comando;
            this.conexion.Open();

            if (this.documento == 10 && rol == "Administrador")
            {
                return 1; // Retornar a la vista de administrador.
            }


            switch (rol)
            {
                case "Madre Comunitaria": // Validar el login de la madre comunitaria.
                    try
                    {
                        comando = new SqlCommand(@"select idMadre from madre_comunitaria where idMadre = @id", this.conexion);
                        comando.Parameters.AddWithValue("@id", this.documento);
                        SqlDataReader datos = comando.ExecuteReader();
                        datos.Read();
                        if (int.Parse(datos["idMadre"].ToString()) == this.documento)
                        {
                            this.conexion.Close();
                            datos.Close();
                            return 2; // Retornar a la vista madre comuntaria.
                        }
                        
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show($"No existe la Madre con el documento {this.documento}","Notificacion",System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                        Console.WriteLine(e);
                    }                   
                    break;
                case "Acudiente": // Validar el rol de el acudiente.
                    try
                    {
                        comando = new SqlCommand(@"select documento from acudiente where documento = @id", this.conexion);
                        comando.Parameters.AddWithValue("@id", this.documento);
                        SqlDataReader datos = comando.ExecuteReader();
                        datos.Read();
                        if (int.Parse(datos["documento"].ToString()) == this.documento)
                        {
                            this.conexion.Close();
                            datos.Close();
                            return 3; // Retornar a la vista acudiente.
                        }
                         
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        System.Windows.Forms.MessageBox.Show($"No existe el Acudiente con el documento {this.documento}", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                    }
                    break;
            }
            this.conexion.Close();
            return 0;
        }
    }
}
