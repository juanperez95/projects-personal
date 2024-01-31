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

namespace Interfaz
{
    public partial class InterfazMadre : Form
    {
        public SqlConnection w = new SqlConnection("server=localhost; database=asociacion;integrated security=true");
        public MadreComunitaria madre = new MadreComunitaria();
        public InterfazMadre()
        {
            w.Open();
            InitializeComponent();
        }

        private void InterfazMadre_Load(object sender, EventArgs e)
        {
            
            displayVistaMadre.DataSource = madre.ViewAsistenciaAndAvance(w,1);
            List<int> ids;
            Login log = new Login(10);
            ids = log.BuscarObjetos("select * from child");
            foreach (var idAsistencia in ids)
            {
                listaAsistenciaId.Items.Add(idAsistencia.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayVistaMadre.DataSource = madre.ViewAsistenciaAndAvance(w,2);
        }

        private void btn_consultarAsistencias_Click(object sender, EventArgs e)
        {
            displayVistaMadre.DataSource = madre.ViewAsistenciaAndAvance(w, 1);
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {           
            if (listaAsistenciaId.Text == string.Empty || listaEstadoAsistencia.Text == string.Empty)
            {
                MessageBox.Show("¡Verifique los campos!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                madre.RegistrarAsistencia(w,int.Parse(listaAsistenciaId.Text),DateTime.Today,listaEstadoAsistencia.Text); // Registrar la asistencia del niño/a.
                displayVistaMadre.DataSource = madre.ViewAsistenciaAndAvance(w, 1); // Actualizar vista.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaAsistenciaId.Text == string.Empty) // Validar que los campos no estne vacios.
            {
                MessageBox.Show("¡Verifique el campo ID Niño!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listaYear.Text == string.Empty || listaYear.Text == string.Empty || listaNivel.Text == string.Empty || listaNotas.Text == string.Empty || txt_descripcion.Text == string.Empty)
                {
                    MessageBox.Show("¡Verifique los campos del avance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Child boy = new Child();
                    boy.GenerarNotas(w, int.Parse(listaAsistenciaId.Text), listaYear.Text, listaNivel.Text, listaNotas.Text, txt_descripcion.Text, Convert.ToDateTime(fechaEntrega.Text));
                    displayVistaMadre.DataSource = madre.ViewAsistenciaAndAvance(w, 2); // Actualizar el datagrid con los avances
                }
            }
        }

        private void btn_filtroAsistencia_Click(object sender, EventArgs e) // Buscar asistencias por id y fecha.
        {
            if (listaAsistenciaId.Text == string.Empty || fechaFiltro.Text == string.Empty) // Validar que los campos no estne vacios.
            {
                MessageBox.Show("¡Verifique el campo ID Niño y la fecha ha filtrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                displayVistaMadre.DataSource = madre.ViewAsistenciaAndAvance(w, 3, int.Parse(listaAsistenciaId.Text), Convert.ToDateTime(fechaFiltro.Text));
            }
        }

        private void btn_filtroAvances_Click(object sender, EventArgs e) // Buscar avace por id y fecha.
        {
            if (listaAsistenciaId.Text == string.Empty || fechaFiltro.Text == string.Empty) // Validar que los campos no estne vacios.
            {
                MessageBox.Show("¡Verifique el campo ID Niño y la fecha ha filtrar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                displayVistaMadre.DataSource = madre.ViewAsistenciaAndAvance(w, 4, int.Parse(listaAsistenciaId.Text), Convert.ToDateTime(fechaFiltro.Text));
            }
        }
    }
}
