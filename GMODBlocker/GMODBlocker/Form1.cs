using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GMODBlocker
{
    public partial class Form1 : Form
    {
        Stopwatch controlTiempo = new Stopwatch();
        DateTime hora = new DateTime();
        Process[] listaProcesos = Process.GetProcesses();
        int minutosShutdown = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Metodo para matar el proceso hl2.exe
        public void killHl2()
        {
            listaProcesos = Process.GetProcesses();
            foreach (Process proceso in listaProcesos)
            {
                if (proceso.ProcessName.ToString() == "hl2")
                    try
                    {
                        proceso.Kill();// Cerrar el proceso
                    }
                    catch (Exception e)
                    {
                        Console.Write(e);
                    }
                    
            }
        }

        // Metodo para apagar el equipo.
        public void shutDownGmod()
        {                    
            Process apagado = new Process();
            apagado.StartInfo.FileName = "shutdown";
            apagado.StartInfo.Arguments = "/s /t 5";
            apagado.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Verificar el proceso del juego..
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            listaProcesos = Process.GetProcesses();
            int contador = 0, porcentaje = 0;           
            // Validar la lista de procesos dentro del sistema
            procesoslb.Text = listaProcesos.Length.ToString();
            // Recorrer la lista de procesos y buscar el proceso ' hl2.exe '
            foreach (Process proceso in listaProcesos)
            {
                contador++;
                porcentaje = contador / listaProcesos.Length*100;
                barraProgreso.Value = porcentaje;
                lbPorcentaje.Text = $"{porcentaje} / 100%".ToString();                
                fileLabel.Text = proceso.ProcessName.ToString().ToUpper();                 
                System.Threading.Thread.Sleep(50);                
                if (proceso.ProcessName.ToString() == "hl2")
                {
                    MessageBox.Show("¡Proceso garry's mod encontrado!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    contador = 0;
                    porcentaje = 0;
                    lbPorcentaje.Text = "0 / 100%";
                    this.Update();
                    // Habilitar los botones y entradas despues cumplir el proceso
                    btnStart.Enabled = true;                    
                    txtTiempo.Enabled = true;
                    txtMinutos.Enabled = true;
                    break;
                }
                this.Update();
            }


        }
        // Hacer andar al contador...
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtMinutos.Text == String.Empty) // Validar el tiempo de apagado
            {
                MessageBox.Show("¡Especifique el tiempo de apagado!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (int.Parse(txtMinutos.Text) > 30 || int.Parse(txtMinutos.Text) < 0) // No exceder 30 minutos.
            {
                MessageBox.Show("¡El tiempo no puede exceder de 30 minutos o inferior a 0!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                button1.Enabled = false;
                hora = Convert.ToDateTime(txtTiempo.Text);
                DateTime horaActual = DateTime.Now;
                TimeSpan diferencia = hora - horaActual;
                if (horaActual.Hour > hora.Hour)
                {
                    MessageBox.Show("¡El tiempo no puede ser inferior al actual!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    minutosShutdown = int.Parse(txtMinutos.Text);
                    controlTiempo.Start();
                    ctrTiempo.Enabled = true;
                    lbPorcentaje.Text = $"Juego disponible : {diferencia.Hours}:" +
                        $"{(diferencia.Minutes.ToString().Length < 2 ? "0" + diferencia.Minutes.ToString(): diferencia.Minutes.ToString())}";
                    // Desactivar boton de verificar
                    btnVerificar.Enabled = false;
                    btnDetener.Enabled = true;
                    clave.Enabled = true;
                    btnStart.Enabled = false;
                }
                             
            }
        }

        private void ctrTiempo_Tick(object sender, EventArgs e)
        {
            DateTime actual = DateTime.Now;
            TimeSpan regresivo = new TimeSpan(0, 0, 0, 0, (int)controlTiempo.ElapsedMilliseconds);
            lbRegresivo.Text = $"{regresivo.Hours}:{(regresivo.Minutes.ToString().Length < 2 ? "0"+ regresivo.Minutes.ToString(): regresivo.Minutes.ToString())}:" +
                $"{(regresivo.Seconds.ToString().Length < 2 ? "0" + regresivo.Seconds.ToString(): regresivo.Seconds.ToString())}";
            // Cuando llegue a la hora seleccionada por el usuario limpia todos los componentes
            if (hora.Hour == actual.Hour && hora.Minute == actual.Minute)
            {
                controlTiempo.Stop();
                ctrTiempo.Enabled = false;
                killHl2();
                lbApagado.Text = $"¡El equipo se apagara en {minutosShutdown} minutos!.";
                // Limpiar el timer para volver a iniciar el aplicativo
                controlTiempo.Reset();
                lbRegresivo.Text = "0:00:00";
                clave.Enabled = true;
                btnDetener.Enabled = true;
                // Iniciar el temporizador desde otra funcion.
                controlTiempo.Start();
                tiempoApagado.Enabled = true;
            }

            
        }

        // Detener el temporizador...
        private void btnDetener_Click(object sender, EventArgs e)
        {
            if(clave.Text != String.Empty) // Validar que el campo de la clave no este vacio
            {
                if (File.Exists("pass.gpass")) // Validar la existencia del archivo que contiene la clave.
                {
                    BinaryReader leerArchivo = new BinaryReader(File.Open("pass.gpass",FileMode.Open));
                    if (leerArchivo.ReadString() == clave.Text) // Comparar la clave digitada con la del archivo
                    {
                        controlTiempo.Reset();
                        ctrTiempo.Enabled = false;
                        lbPorcentaje.Text = "0:00:00";
                        btnStart.Enabled = true;
                        btnVerificar.Enabled = true;
                        btnDetener.Enabled = false;
                        MessageBox.Show("¡Temporizador detenido!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clave.Text = String.Empty;
                        button1.Enabled = true;
                        clave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("¡No coincide la contraseña!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clave.Text = String.Empty;
                    }
                    leerArchivo.Close();
                }
                else // De lo contrario crea el archivo con la clave digitada por primera vez.
                {
                    BinaryWriter archivoNuevo = new BinaryWriter(File.Open("pass.gpass", FileMode.Create));
                    archivoNuevo.Write(clave.Text);
                    MessageBox.Show("¡Clave creada correctamente!", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    archivoNuevo.Close();
                    clave.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("¡Coloque una clave!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tiempoApagado_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoFinal = new TimeSpan(0, 0, 0, 0, (int)controlTiempo.ElapsedMilliseconds);
            lbRegresivo.Text = $"0:{(tiempoFinal.Minutes.ToString().Length < 2 ? "0" + tiempoFinal.Minutes.ToString(): tiempoFinal.Minutes.ToString())}" +
                $":{(tiempoFinal.Seconds.ToString().Length < 2 ? "0" + tiempoFinal.Seconds.ToString(): tiempoFinal.Seconds.ToString())}";
            killHl2();
            if (tiempoFinal.Minutes == minutosShutdown)
            {
                controlTiempo.Stop();
                tiempoApagado.Enabled = false;
                shutDownGmod(); // Llamar la funcion para apagar el equipo.

            }
        }
    }
}
