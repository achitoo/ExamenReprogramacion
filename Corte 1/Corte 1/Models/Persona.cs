using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Models
{
    internal class Persona
    {
        private string nombre {  get; set; }

        private string apellido { get; set; }

        public DateTime fechaNacimiento { get; set; }

        private string ciudad {  get; set; }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, string ciudad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.ciudad = ciudad;
        }
    }
}
