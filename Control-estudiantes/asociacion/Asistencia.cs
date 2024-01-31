using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    public class Asistencia
    {
        private DateTime fecha;
        private string descripcion;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Asistencia(DateTime fecha, string descripcion)
        {
            this.fecha = fecha;
            this.descripcion = descripcion;
        }

        public int ValidarAsistencia()
        {
            DateTime horas = DateTime.Now;
            if (horas.Hour >= 8 && horas.Hour < 10)
            {
                if (this.descripcion == "ENFERMO")
                    return 1; // Si esta enfermo notificar al administrador.
                return 2; // Si la asistencia esta entre 8 a 10
            }
            return 0; // Si no cumple la hora de asistencia.
        }
    }
}
