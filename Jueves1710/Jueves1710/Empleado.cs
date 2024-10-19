using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Empleado
    {
        const int sueldo = 1000;
        const string nombre = "Nuevo Empleado";
        const string cargo = "Empleado Base";

        public int Sueldo { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }

        public Empleado() {
            Nombre = nombre;
            Sueldo = sueldo;
            Cargo = cargo;
        }

        public Empleado(int sueldo, string nombre, string cargo)
        {
            Sueldo = sueldo;
            Nombre = nombre;
            Cargo = cargo;
        }

        public void Imprimir()
        {
            Console.WriteLine($"El empleado {Nombre} tiene el cargo {Cargo} y su sueldo es {Sueldo}");
        }
    }
}
