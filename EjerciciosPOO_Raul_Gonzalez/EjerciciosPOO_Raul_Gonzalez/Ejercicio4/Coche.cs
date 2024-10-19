using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio4
{
    internal class Coche : IVehiculo
    {
        int _gasolina;
        public Coche(int gasolina) {
            _gasolina = gasolina;
        }

        public void Conducir()
        {
            if (_gasolina > 0)
            {
                Console.WriteLine("Conduciendo...");
            }
            else { Console.WriteLine("No hay gasofa"); }
        }

        public bool Repostar(int cantidad)
        {
            _gasolina += cantidad;
            return true;
        }
    }
}
