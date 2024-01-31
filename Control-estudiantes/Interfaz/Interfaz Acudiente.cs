using asociacion;
using LogIn;
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

namespace Interfaz
{
    public partial class Interfaz_Acudiente : Form
    {
        private int idAcudiente;
        public SqlConnection w = new SqlConnection("server=localhost; database=asociacion; integrated security=true");
        public int IdAcudiente { get => idAcudiente; set => idAcudiente = value; }

        public Interfaz_Acudiente(int id)
        {
            w.Open();
            this.idAcudiente = id;
            InitializeComponent();
        }

        

        private void Interfaz_Acudiente_Load(object sender, EventArgs e)
        {           
            Login log = new Login(this.idAcudiente);
            Acudiente acudiente = log.ObjetoAcudiente(this.idAcudiente);            
            txt_acudiente.Text = acudiente.Nombres.ToUpper();
            displayAcudiente.DataSource = acudiente.ConsultarAvance(w, this.idAcudiente,1);           
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Acudiente acudiente = new Acudiente();
            if (txt_Id.Text == string.Empty)
            {
                MessageBox.Show("¡Llene el ID antes de filtrar!","Notificacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                displayAcudiente.DataSource = acudiente.ConsultarAvance(w, this.idAcudiente, 1);
            }
            else
            {
                Child child = new Child();
                child.Identificacion = int.Parse(txt_Id.Text);
                displayAcudiente.DataSource = acudiente.ConsultarAvance(w, child.Identificacion, 2,Convert.ToDateTime(fechaFiltro.Text));
                child.ValidarCumpleanos(w);
            }
        }
    }
}
