using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio1
{
    internal class Persona
    {
        string _nombre;

        public Persona()
        {
            _nombre = string.Empty;
        }

        public void PedirNombre()
        {
            Console.Write("Escriba un nombre: ");
             _nombre = Console.ReadLine();
        }

     

        public override string ToString()
        {
            return $"Me llamo {_nombre}";
        }

    }
}
