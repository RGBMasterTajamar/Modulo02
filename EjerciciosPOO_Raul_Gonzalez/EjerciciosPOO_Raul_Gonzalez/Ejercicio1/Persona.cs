using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio1
{
    internal class Persona
    {
        public string Nombre { get; set; }  

        public override string ToString()
        {
            return $"Me llamo {Nombre}";
        }

    }
}
