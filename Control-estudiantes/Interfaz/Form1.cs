using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogIn;

namespace Interfaz
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vista = 0; // Redirigir a la vista.
            if(txt_documento.Text == string.Empty || listRol.Text == string.Empty)
            {
                MessageBox.Show("¡No deje campos vacios!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Login logueo = new Login(int.Parse(txt_documento.Text));
                vista = logueo.validarLogin(listRol.Text);
                switch (vista)
                {
                    case 1:
                        InterfazAdministrador admin = new InterfazAdministrador();
                        admin.Show();
                        break;
                    case 2:
                        InterfazMadre vistaMadre = new InterfazMadre();
                        vistaMadre.Show();
                        break;
                    case 3:
                        Interfaz_Acudiente vistaAcudiente = new Interfaz_Acudiente(int.Parse(txt_documento.Text)); // Pasar acudiente al momento de registrarse
                        vistaAcudiente.Show();
                        break;
                }
            }
            
        }
    }
}
