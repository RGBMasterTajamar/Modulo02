using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio2
{
    internal class Estudiante : Personas
    {
        // Metodo Estudiar();
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando...");
        }

        public void VerEdad()
        {
            Console.WriteLine($"Tengo {Edad} años");
        }

    }
}
