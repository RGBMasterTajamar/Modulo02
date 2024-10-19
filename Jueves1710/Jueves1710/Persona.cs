using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        private int CalcularEdad(DateTime fecha)
        {
            int año=fecha.Year;
            int actual= DateTime.Now.Year;
            return actual-año;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola me llamo {Nombre} y tengo {CalcularEdad(FechaNacimiento)}");
        }
    }
}
