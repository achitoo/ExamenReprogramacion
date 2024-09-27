using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Models
{
    internal class Operacion
    {
        public int CalcularEdad(Persona persona)
        {
            int edad = DateTime.Now.Year - persona.fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < persona.fechaNacimiento.DayOfYear)
                edad--;

            return edad;
        }

        public string EsMayorDeEdad(Persona persona)
        {
            int edad = CalcularEdad(persona);
            return edad >= 18 ? "Mayor de edad" : "Menor de edad";
        }
    }
}
