using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asociacion;
using LogIn;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Interfaz
{
    public partial class InterfazAdministrador : Form
    {
        public Administrador admin;
        public SqlConnection w = new SqlConnection("server=localhost; database=asociacion; integrated security=true");
        public InterfazAdministrador()
        {
            admin = new Administrador();
            InitializeComponent();
            w.Open();
        }

        private void btn_jardin_Click(object sender, EventArgs e)
        {
            // Limpiar los datos al oprimir el boton
            txt_buscar.Text = "";
            txtCorreo.Text = "";
            listaAcudiente.Text = "";
            listaEps.Text = "";
            listaSangre.Text = "";
            listaJardin.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
            listaJardin.Text = "";
            txtFechaNacimiento.Text = "";
            listaEstadoJardin.Text = "";
            txtDireccion.Text = "";

            // Activar los botones del crud al oprimir alguna de la entidades.
            txt_buscar.Enabled = true;
            btn_agregar.Enabled = true;
            btn_consultar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;

            entidad.Text = btn_jardin.Text;
            // Validar las entradas activas para los botones.
            txtCorreo.Enabled = false;
            listaAcudiente.Enabled = false;
            listaEps.Enabled = false;
            listaSangre.Enabled = false;
            listaJardin.Enabled = false;
            txtNombres.Enabled = true;
            txtTelefono.Enabled = false;
            txtId.Enabled = true;
            listaJardin.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            listaEstadoJardin.Enabled = true;
            txtDireccion.Enabled = true;
            listaCity.Enabled = false;

        }

        private void btn_acudiente_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            txtCorreo.Text = "";
            listaAcudiente.Text = "";
            listaEps.Text = "";
            listaSangre.Text = "";
            listaJardin.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
            listaJardin.Text = "";
            txtFechaNacimiento.Text = "";
            listaEstadoJardin.Text = "";
            txtDireccion.Text = "";

            txt_buscar.Enabled = true;
            btn_agregar.Enabled = true;
            btn_consultar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;


            entidad.Text = btn_acudiente.Text;

            txtCorreo.Enabled = true;
            listaAcudiente.Enabled = false;
            listaEps.Enabled = false;
            listaSangre.Enabled = false;
            listaJardin.Enabled = false;
            txtNombres.Enabled = true;
            txtTelefono.Enabled = true;
            txtId.Enabled = true;
            listaJardin.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            listaEstadoJardin.Enabled = false;
            listaCity.Enabled = false;
        }

        private void btn_child_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            listaJardin.Items.Clear();
            listaAcudiente.Items.Clear(); // Limpiar las listas para que no se acumule la informacion

            Login cons = new Login(10);
            // Agregar las llaves foraneas de el jardin.
            List<int> data = cons.BuscarObjetos("select * from jardin where estado = 'APROBADO'", 0); // Solo validar los jardines aprobados.
            foreach (var item in data)
            {
                listaJardin.Items.Add(item.ToString());
            }


            // Llaves foraneas del acudiente
            List<int> datos = cons.BuscarObjetos("select * from acudiente", 1);
            foreach (var item in datos)
            {
                listaAcudiente.Items.Add(item.ToString());
            }

            txtCorreo.Text = "";
            listaAcudiente.Text = "";
            listaEps.Text = "";
            listaSangre.Text = "";
            listaJardin.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
            listaJardin.Text = "";
            txtFechaNacimiento.Text = "";
            listaEstadoJardin.Text = "";
            txtDireccion.Text = "";

            txt_buscar.Enabled = true;
            btn_agregar.Enabled = true;
            btn_consultar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;


            entidad.Text = btn_child.Text;

            txtCorreo.Enabled = false;
            listaAcudiente.Enabled = true;
            listaEps.Enabled = true;
            listaSangre.Enabled = true;
            listaJardin.Enabled = true;
            txtNombres.Enabled = true;
            txtTelefono.Enabled = true;
            txtId.Enabled = true;
            listaJardin.Enabled = true;
            txtFechaNacimiento.Enabled = true;
            listaEstadoJardin.Enabled = false;
            listaCity.Enabled = true;

        }

        private void btn_madre_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            txtCorreo.Text = "";
            listaAcudiente.Text = "";
            listaEps.Text = "";
            listaSangre.Text = "";
            listaJardin.Text = "";
            txtNombres.Text = "";
            txtTelefono.Text = "";
            txtId.Text = "";
            listaJardin.Text = "";
            txtFechaNacimiento.Text = "";
            listaEstadoJardin.Text = "";
            txtDireccion.Text = "";

            txt_buscar.Enabled = true;
            btn_agregar.Enabled = true;
            btn_consultar.Enabled = true;
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;

            entidad.Text = btn_madre.Text;

            txtCorreo.Enabled = false;
            listaAcudiente.Enabled = false;
            listaEps.Enabled = false;
            listaSangre.Enabled = false;
            listaJardin.Enabled = false;
            txtNombres.Enabled = true;
            txtTelefono.Enabled = true;
            txtId.Enabled = true;
            listaJardin.Enabled = false;
            txtFechaNacimiento.Enabled = true;
            listaEstadoJardin.Enabled = false;
            listaCity.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (entidad.Text)
            {
                case "Jardin":
                    Jardin jardin = new Jardin();
                    // Recoger datos del jardin y setearlos al objeto.
                    jardin.IdJardin = int.Parse(txtId.Text);
                    jardin.NombreJardin = txtNombres.Text;
                    jardin.Direccion = txtDireccion.Text;
                    jardin.Estado = listaEstadoJardin.Text;

                    admin.AgregarUsuario(w, 4,0,0, null, null, null, jardin);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 4);
                    break;
                case "Acudiente":
                    Acudiente acudiente = new Acudiente();
                    acudiente.Correo = txtCorreo.Text;
                    acudiente.Direccion = txtDireccion.Text;
                    acudiente.Identificacion = int.Parse(txtId.Text);
                    acudiente.Nombres = txtNombres.Text;
                    acudiente.Telefono = txtTelefono.Text;
                    admin.AgregarUsuario(w, 1,0,0, null, acudiente);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 2);
                    break;
                case "Madre Comunitaria":
                    MadreComunitaria madre = new MadreComunitaria();
                    madre.Nombres = txtNombres.Text;
                    madre.Identificacion = int.Parse(txtId.Text);
                    madre.Direccion = txtDireccion.Text;
                    madre.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                    madre.Telefono = txtTelefono.Text;
                    admin.AgregarUsuario(w, 2,0,0, madre);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 3);
                    break;
                case "Child":
                    Child boy = new Child();
                    boy.CiudadNacimiento = listaCity.Text;
                    boy.Direccion = txtDireccion.Text;
                    boy.EPS1 = listaEps.Text;
                    boy.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                    boy.Identificacion = int.Parse(txtId.Text);
                    boy.Nombres = txtNombres.Text;
                    boy.Telefono = txtTelefono.Text;
                    boy.TipoSangre = listaSangre.Text;
                    boy.IdAcudiente = int.Parse(listaJardin.Text);
                    boy.IdJardin = int.Parse(listaAcudiente.Text);
                    admin.AgregarUsuario(w, 3, int.Parse(listaAcudiente.Text), int.Parse(listaJardin.Text), null, null, boy);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 1);
                    break;
            }
            txt_buscar.Text = "";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;

            Login objetos = new Login(10);
            int opcionTabla;
            if (txt_buscar.Text == string.Empty)
            {
                opcionTabla = 0;
            }
            else
            {
                opcionTabla = int.Parse(txt_buscar.Text);
            }

            // Llenar los txt con los datos del objeto a consultar.
            switch (entidad.Text)
            {
                case "Jardin":
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, opcionTabla, 4);
                    Jardin jardin = objetos.ObjetoJardin(opcionTabla);
                    txtId.Text = jardin.IdJardin.ToString();
                    txtNombres.Text = jardin.NombreJardin;
                    txtDireccion.Text = jardin.Direccion;
                    listaEstadoJardin.Text = jardin.Estado;

                    break;
                case "Acudiente":
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w,opcionTabla,2);
                    Acudiente acudiente = objetos.ObjetoAcudiente(opcionTabla);
                    txtCorreo.Text = acudiente.Correo;
                    txtDireccion.Text = acudiente.Direccion;
                    txtId.Text = acudiente.Identificacion.ToString();
                    txtNombres.Text = acudiente.Nombres;
                    txtTelefono.Text = acudiente.Telefono;

                    break;
                case "Madre Comunitaria":
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w,opcionTabla,3);
                    MadreComunitaria madre = objetos.ObjetoMother(opcionTabla);
                    txtNombres.Text = madre.Nombres;
                    txtId.Text = madre.Identificacion.ToString();
                    txtDireccion.Text = madre.Direccion;
                    txtFechaNacimiento.Text = madre.FechaNacimiento.ToString();
                    txtTelefono.Text = madre.Telefono;

                    break;
                case "Child":
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, opcionTabla, 1);
                    Child boy = objetos.ObjetoBoy(opcionTabla);

                    listaCity.Text = boy.CiudadNacimiento;
                    txtDireccion.Text = boy.Direccion;
                    listaEps.Text = boy.EPS1;
                    txtFechaNacimiento.Text = boy.FechaNacimiento.ToString();
                    txtId.Text = boy.Identificacion.ToString();
                    txtNombres.Text = boy.Nombres;
                    txtTelefono.Text = boy.Telefono;
                    listaSangre.Text = boy.TipoSangre;
                    listaAcudiente.Text = boy.IdAcudiente.ToString();
                    listaJardin.Text = boy.IdJardin.ToString();
                    boy.ValidarCumpleanos(w);
                    break;
            }
            txt_buscar.Text = "";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            switch (entidad.Text)
            {
                case "Jardin":
                    Jardin jardin = new Jardin();
                    // Recoger datos del jardin y setearlos al objeto.
                    jardin.IdJardin = int.Parse(txtId.Text);
                    jardin.NombreJardin = txtNombres.Text;
                    jardin.Direccion = txtDireccion.Text;
                    jardin.Estado = listaEstadoJardin.Text;

                    admin.EditarUsuario(w, 4, null, null, null, null, jardin);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 4);
                    break;
                case "Acudiente":
                    Acudiente acudiente = new Acudiente();
                    acudiente.Correo = txtCorreo.Text;
                    acudiente.Direccion = txtDireccion.Text;
                    acudiente.Identificacion = int.Parse(txtId.Text);
                    acudiente.Nombres = txtNombres.Text;
                    acudiente.Telefono = txtTelefono.Text;
                    admin.EditarUsuario(w,2,null,null,null,acudiente);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 2);
                    break;
                case "Madre Comunitaria":
                    MadreComunitaria madre = new MadreComunitaria();
                    madre.Nombres = txtNombres.Text;
                    madre.Identificacion = int.Parse(txtId.Text);
                    madre.Direccion = txtDireccion.Text;
                    madre.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                    madre.Telefono = txtTelefono.Text;
                    admin.EditarUsuario(w, 3, null, null, madre);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 3);
                    break;
                case "Child":
                    Child boy = new Child();
                    boy.CiudadNacimiento = listaCity.Text;
                    boy.Direccion = txtDireccion.Text;
                    boy.EPS1 = listaEps.Text;
                    boy.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                    boy.Identificacion = int.Parse(txtId.Text);
                    boy.Nombres = txtNombres.Text;
                    boy.Telefono = txtTelefono.Text;
                    boy.TipoSangre = listaSangre.Text;
                    boy.IdJardin = int.Parse(listaJardin.Text);
                    boy.IdAcudiente = int.Parse(listaAcudiente.Text);
                    admin.EditarUsuario(w, 1, null, boy);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 1);
                    break;
            }
            txt_buscar.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int opcionTabla;
            if (txt_buscar.Text == string.Empty)
            {
                opcionTabla = 0;
            }
            else
            {
                opcionTabla = int.Parse(txt_buscar.Text);
            }

            switch (entidad.Text)
            {
                case "Jardin":
                    admin.EliminarUsuario(w, 4, opcionTabla);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 4);
                    break;
                case "Acudiente":
                    admin.EliminarUsuario(w, 2, opcionTabla);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 2);
                    break;
                case "Madre Comunitaria":
                    admin.EliminarUsuario(w, 3, opcionTabla);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 3);
                    break;
                case "Child":
                    admin.EliminarUsuario(w, 1, opcionTabla);
                    displayAdmin.DataSource = admin.ConsultarUsuarios(w, 0, 1);
                    break;
            }
            txt_buscar.Text = "";
        }
    }
}
