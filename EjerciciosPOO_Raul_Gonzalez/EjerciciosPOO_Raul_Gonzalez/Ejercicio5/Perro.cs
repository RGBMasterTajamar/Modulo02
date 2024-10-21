using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio5
{
    internal class Perro : Animal
    {
        public override void Comer()
        {
            Console.WriteLine($"{GetNombre()} está comiendo.");
        }
    }
}
