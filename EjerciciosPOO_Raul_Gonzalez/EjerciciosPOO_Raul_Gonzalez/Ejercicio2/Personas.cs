using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio2
{
    internal class Personas
    {
        protected int Edad;

        public void Saludar()
        {
            Console.WriteLine("Hola soy una persona");
        }

        public void AsignarEdad(int edad)
        {
            Edad = edad;
        }

    }
}
