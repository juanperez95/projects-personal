using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    public class Usuario
    {
        protected int identificacion;
        protected string nombres;
        protected string telefono;
        protected string direccion;
        protected DateTime fechaNacimiento;

        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        // Sobrecarga del metodo para validar las reglas de negocio de cada clase.
        public int Validaciones()
        {
            return 0;
        }

    }


}
