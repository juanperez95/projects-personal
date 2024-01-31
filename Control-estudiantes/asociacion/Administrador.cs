using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Windows.Forms;

namespace asociacion
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
        }

        // Generar metodos para la base de datos
        public void AgregarUsuario(SqlConnection conexion, int tabla,int fk_acudiente, int fk_jardin, MadreComunitaria madre = null, Acudiente acudiente = null,
            Child boy = null, Jardin jardin = null)
        {
            
            switch (tabla)
            {
                case 1: // Registrar acudiente -----------------------------------------------------------------------------------
                    SqlCommand cmd = new SqlCommand(@"insert into acudiente values(@nombre,@documento,@telefono,@celular,@direccion,@correo)", conexion);
                    cmd.Parameters.AddWithValue("@nombre",acudiente.Nombres);
                    cmd.Parameters.AddWithValue("@documento", acudiente.Identificacion);
                    cmd.Parameters.AddWithValue("@telefono", acudiente.Telefono);
                    cmd.Parameters.AddWithValue("@celular", acudiente.Telefono);
                    cmd.Parameters.AddWithValue("@direccion", acudiente.Direccion);
                    cmd.Parameters.AddWithValue("@correo", acudiente.Correo);
                    cmd.ExecuteNonQuery();                   
                    System.Windows.Forms.MessageBox.Show($"¡Registro exitoso de Acudiente {acudiente.Nombres}!","Notificacion",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
                    break;
                case 2: // Registrar madre comunitaria --------------------------------------------------------------
                    if(madre.Validaciones(conexion) == 0) // Validar si el id de la madre no esta registrado.
                    {
                        cmd = new SqlCommand(@"insert into madre_comunitaria values(@idMadre,@nombres,@telefono,@direccion,@fechaNacimiento)", conexion);
                        cmd.Parameters.AddWithValue("@idMadre", madre.Identificacion);
                        cmd.Parameters.AddWithValue("@nombres", madre.Nombres);
                        cmd.Parameters.AddWithValue("@telefono", madre.Telefono);
                        cmd.Parameters.AddWithValue("@direccion", madre.Direccion);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", madre.FechaNacimiento);
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show($"¡Registro exitoso de Madre Comunitaria {madre.Nombres}!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        break;
                    }else
                        System.Windows.Forms.MessageBox.Show($"¡Ya existe la Madre Comunitaria!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                    break;
                case 3: // Registrar niños -----------------------------------------------------------------------------------
                    if (boy.Validaciones(conexion) == 0)
                    {
                        cmd = new SqlCommand(@"insert into child values(@registro,@nombres,@fechaNacimiento,@tipoSangre,@ciudadN,@idAcudiente,@tel,
                        @direccion,@eps,@idJardin)", conexion);
                        cmd.Parameters.AddWithValue("@registro", boy.Identificacion);
                        cmd.Parameters.AddWithValue("@nombres", boy.Nombres);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", boy.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@tipoSangre", boy.TipoSangre);
                        cmd.Parameters.AddWithValue("@ciudadN", boy.CiudadNacimiento);
                        cmd.Parameters.AddWithValue("@idAcudiente", fk_acudiente);
                        cmd.Parameters.AddWithValue("@tel", boy.Telefono);
                        cmd.Parameters.AddWithValue("@direccion", boy.Direccion);
                        cmd.Parameters.AddWithValue("@eps", boy.EPS1);
                        cmd.Parameters.AddWithValue("@idJardin", fk_jardin);
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show($"¡Registro exitoso de Niño {boy.Nombres}!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        break;
                    }else if(boy.Validaciones(conexion) == 1)
                        System.Windows.Forms.MessageBox.Show($"¡Ya existe el Niñ@!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    else if (boy.Validaciones(conexion) == 2)
                        System.Windows.Forms.MessageBox.Show($"¡No se puede registrar por ser mayor a 5 años!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                    break;
                case 4: // Registrar Jardines --------------------------------------------------------------------------------------------
                    if (jardin.Validaciones(conexion) == 0)
                    {
                        cmd = new SqlCommand(@"insert into jardin values(@idJardin,@nombreJardin,@direccion,@estado)", conexion);
                        cmd.Parameters.AddWithValue("@idJardin", jardin.IdJardin);
                        cmd.Parameters.AddWithValue("@nombreJardin", jardin.NombreJardin);
                        cmd.Parameters.AddWithValue("@direccion", jardin.Direccion);
                        cmd.Parameters.AddWithValue("@estado", jardin.Estado);

                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show($"¡Registro exitoso de Jardin {jardin.NombreJardin}!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                        break;
                    }
                    else if (jardin.Validaciones(conexion) == 1)
                        System.Windows.Forms.MessageBox.Show($"¡Ya existe el Jardin!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
            }   
            
        }

        public DataTable ConsultarUsuarios(SqlConnection conexion, int buscar = 0, int tabla = 1)
        {
            DataTable esquema = new DataTable();
            
            if(buscar != 0) // Validar si la busqueda no esta vacia.
            {
                
                switch (tabla)
                {
                    case 1: // Consultar a los niños
                        SqlCommand cmd = new SqlCommand(@"select * from child where registro = @buscar", conexion); // Consultar vista.
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        data.Fill(esquema); // Llenar los datos de la base a la tabla.
                        break;
                    case 2: // Consultar a los acudientes
                        cmd = new SqlCommand(@"select * from acudiente where documento = @buscar", conexion);
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        data = new SqlDataAdapter(cmd);
                        data.Fill(esquema);
                        break;
                    case 3: // Consultar a las madres
                        cmd = new SqlCommand(@"select * from madre_comunitaria where idMadre = @buscar", conexion);
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        data = new SqlDataAdapter(cmd);
                        data.Fill(esquema);
                        break;
                    case 4: // Consultar jardines
                        cmd = new SqlCommand(@"select * from jardin where idJardin = @buscar", conexion);
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        data = new SqlDataAdapter(cmd);
                        data.Fill(esquema);
                        break;
                }

            }
            else
            {
                switch (tabla) // Se sigue el mismo orden , solo trae todo lo que hay en las tablas si la busqueda no se realizo en la interfaz.
                {
                    case 1:
                        SqlCommand cmd = new SqlCommand("select * from child", conexion);
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        data.Fill(esquema);
                        break;
                    case 2:
                        cmd = new SqlCommand("select * from acudiente", conexion);
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        data = new SqlDataAdapter(cmd);
                        data.Fill(esquema);
                        break;
                    case 3:
                        cmd = new SqlCommand("select * from madre_comunitaria", conexion);
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        data = new SqlDataAdapter(cmd);
                        data.Fill(esquema);
                        break;
                    case 4:
                        cmd = new SqlCommand("select * from jardin", conexion);
                        cmd.Parameters.AddWithValue("@buscar", buscar);
                        data = new SqlDataAdapter(cmd);
                        data.Fill(esquema);
                        break;
                }
            }
            
            return esquema; // Devolver la tabla para el datagrid y visuarlizarlo
        }

        public void EliminarUsuario(SqlConnection conexion, int tabla, int buscar = 0)
        {
            if (buscar == 0)
                System.Windows.Forms.MessageBox.Show("¡Campo vacio para buscar al usuario!","Notificacion",System.Windows.Forms.MessageBoxButtons.OK
                    ,System.Windows.Forms.MessageBoxIcon.Error);
            else // Si el textbox en la interfaz tiene un dato ejecuta y valida a quien tiene que eliminar.
            {
                switch (tabla)
                {
                    case 1: // Eliminar a los niños
                        SqlCommand cmd = new SqlCommand(@"select nombres from child where registro = @id", conexion); // Primero se consulta para hacer una validacion
                        cmd.Parameters.AddWithValue("@id", buscar);
                        SqlDataReader data = cmd.ExecuteReader();
                        data.Read();
                        DialogResult respuesta = System.Windows.Forms.MessageBox.Show($"¡Esta seguro de eliminar al usuario {data["nombres"]}, tenga en cuenta que se eliminaran las asistencia y el avance academico!", "Notificacion", System.Windows.Forms.MessageBoxButtons.YesNo
                            , System.Windows.Forms.MessageBoxIcon.Exclamation);
                        data.Close();

                        if (respuesta == DialogResult.Yes) // Validar si confirman borrar al usuario
                        {
                            cmd = new SqlCommand(@"delete from asistencia where idChild = @id", conexion); // Eliminar primero la foranea de asistencia para avitar problemas
                            cmd.Parameters.AddWithValue("@id", buscar);
                            int asistencias = cmd.ExecuteNonQuery();

                            cmd = new SqlCommand(@"delete from avance_academico where idChild = @id", conexion); // Eliminar despues la foranea de avance academico para avitar problemas
                            cmd.Parameters.AddWithValue("@id", buscar);
                            int avanceAcademico = cmd.ExecuteNonQuery();

                            cmd = new SqlCommand(@"delete from child where registro = @id", conexion); // Eliminar el registro de tabla child
                            cmd.Parameters.AddWithValue("@id", buscar);
                            cmd.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show($"¡Se ha eliminado correctamente!, Se borraron {asistencias} asistencias y {avanceAcademico} avances academicos.", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Information);
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("¡Se cancelo la operacion!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Information);
                        break;
                    case 2: // Eliminar Acudiente
                        cmd = new SqlCommand(@"select nombre from acudiente where documento = @id", conexion); // Primero se consulta para hacer una validacion
                        cmd.Parameters.AddWithValue("@id", buscar);
                        data = cmd.ExecuteReader();
                        data.Read();
                        respuesta = System.Windows.Forms.MessageBox.Show($"¡Esta seguro de eliminar al usuario {data["nombre"]}!", "Notificacion", System.Windows.Forms.MessageBoxButtons.YesNo
                            , System.Windows.Forms.MessageBoxIcon.Exclamation);
                        data.Close();

                        if (respuesta == DialogResult.Yes) // Validar si confirman borrar al usuario
                        {
                            cmd = new SqlCommand(@"delete from acudiente where documento = @id", conexion); // Eliminar el registro de tabla child
                            cmd.Parameters.AddWithValue("@id", buscar);
                            cmd.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show($"¡Se ha eliminado correctamente!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Information);
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("¡Se cancelo la operacion!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Information);
                        break;
                    case 3: // Eliminar Madres Comunitarias
                        cmd = new SqlCommand(@"select nombres from madre_comunitaria where idMadre = @id", conexion); // Primero se consulta para hacer una validacion
                        cmd.Parameters.AddWithValue("@id", buscar);
                        data = cmd.ExecuteReader();
                        data.Read();
                        respuesta = System.Windows.Forms.MessageBox.Show($"¡Esta seguro de eliminar al usuario {data["nombres"]}!", "Notificacion", System.Windows.Forms.MessageBoxButtons.YesNo
                            , System.Windows.Forms.MessageBoxIcon.Exclamation);
                        data.Close();

                        if (respuesta == DialogResult.Yes) // Validar si confirman borrar al usuario
                        {
                            cmd = new SqlCommand(@"delete from madre_comunitaria where idMadre = @id", conexion); // Eliminar el registro de tabla child
                            cmd.Parameters.AddWithValue("@id", buscar);
                            cmd.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show($"¡Se ha eliminado correctamente!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Information);
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("¡Se cancelo la operacion!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Information);
                        break;
                    case 4: // Eliminar Jardines
                        cmd = new SqlCommand(@"select nombreJardin from jardin where idJardin = @id", conexion); // Primero se consulta para hacer una validacion
                        cmd.Parameters.AddWithValue("@id", buscar);
                        data = cmd.ExecuteReader();
                        data.Read();
                        respuesta = System.Windows.Forms.MessageBox.Show($"¡Esta seguro de eliminar el Jardin {data["nombreJardin"]}!", "Notificacion", System.Windows.Forms.MessageBoxButtons.YesNo
                            , System.Windows.Forms.MessageBoxIcon.Exclamation);
                        data.Close();

                        if (respuesta == DialogResult.Yes) // Validar si confirman borrar al usuario
                        {
                            try
                            {
                                cmd = new SqlCommand(@"delete from jardin where idJardin = @id", conexion); // Eliminar el registro de tabla child
                                cmd.Parameters.AddWithValue("@id", buscar);
                                cmd.ExecuteNonQuery();
                                System.Windows.Forms.MessageBox.Show($"¡Se ha eliminado correctamente!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                                , System.Windows.Forms.MessageBoxIcon.Information);
                            }
                            catch (Exception)
                            {
                                System.Windows.Forms.MessageBox.Show("¡Valide que el jardin no este vinculado con los niños!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Stop);
                            }
                            
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("¡Se cancelo la operacion!", "Notificacion", System.Windows.Forms.MessageBoxButtons.OK
                            , System.Windows.Forms.MessageBoxIcon.Information);
                        break;

                }

            }

        }

        public void EditarUsuario(SqlConnection conexion, int tabla = 0, Usuario user = null, Child boy = null, MadreComunitaria mother = null,
            Acudiente acudiente = null, Jardin jardin = null)
        {
            if(tabla == 0) // Validar el textbox 
                MessageBox.Show("¡Digite un el id para buscar el id!","Notificacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                switch (tabla)
                {
                    case 1: // Actualizar niño -------------------------------------------------------------
                        SqlCommand cmd = new SqlCommand(@"update child set nombres = @nombres, fechaNacimiento = @fechaN, tipoSangre = @tSangre" +
                            ",ciudadNacimiento = @ciudad, idAcudiente = @acudiente, telefono = @tel, direccion = @direccion" +
                            ",eps = @eps, idJardin = @jardin where registro = @id",conexion);
                        cmd.Parameters.AddWithValue("@nombres",boy.Nombres);
                        cmd.Parameters.AddWithValue("@fechaN", boy.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@tSangre", boy.TipoSangre);
                        cmd.Parameters.AddWithValue("@ciudad", boy.CiudadNacimiento);
                        cmd.Parameters.AddWithValue("@acudiente", boy.IdAcudiente);
                        cmd.Parameters.AddWithValue("@tel", boy.Telefono);
                        cmd.Parameters.AddWithValue("@direccion", boy.Direccion);
                        cmd.Parameters.AddWithValue("@eps", boy.EPS1);
                        cmd.Parameters.AddWithValue("@jardin", boy.IdJardin);
                        cmd.Parameters.AddWithValue("@id", boy.Identificacion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Se ha actualizado al Niñ@ correctamente!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2: // Actualizar acudiente --------------------------------------------------------
                        cmd = new SqlCommand(@"update acudiente set nombre = @nombre, telefono = @tel, celular = @cel, direccion = @direccion, correo = @correo where documento = @id", conexion);
                        cmd.Parameters.AddWithValue("@nombre", acudiente.Nombres);
                        cmd.Parameters.AddWithValue("@tel", acudiente.Telefono);
                        cmd.Parameters.AddWithValue("@cel", acudiente.Telefono);
                        cmd.Parameters.AddWithValue("@direccion", acudiente.Direccion);
                        cmd.Parameters.AddWithValue("@correo", acudiente.Correo);
                        cmd.Parameters.AddWithValue("@id", acudiente.Identificacion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Se ha actualizado al acudiente correctamente!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3: // Actualizar Madre Comunitaria --------------------------------------------------------
                        cmd = new SqlCommand(@"update madre_comunitaria set nombres = @nombres, telefono = @tel, direccionResidencia = @direccion, fechaNacimiento = @fecha 
                        where idMadre = @id", conexion);
                        cmd.Parameters.AddWithValue("@nombres", mother.Nombres);
                        cmd.Parameters.AddWithValue("@tel", mother.Telefono);
                        cmd.Parameters.AddWithValue("@direccion", mother.Direccion);
                        cmd.Parameters.AddWithValue("@fecha", mother.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@id", mother.Identificacion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Se ha actualizado a la Madre correctamente!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4: // Actualizar Jardin --------------------------------------------------------
                        cmd = new SqlCommand(@"update jardin set nombreJardin = @nombre, direccion = @direccion, estado = @estado where idJardin = @id", conexion);
                        cmd.Parameters.AddWithValue("@nombre", jardin.NombreJardin);
                        cmd.Parameters.AddWithValue("@direccion", jardin.Direccion);
                        cmd.Parameters.AddWithValue("@estado", jardin.Estado);
                        cmd.Parameters.AddWithValue("@id", jardin.IdJardin);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("¡Se ha actualizado el Jardin correctamente!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
        }


    }


}
