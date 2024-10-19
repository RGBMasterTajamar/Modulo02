using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Carro : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando...");
        }
    }
}
