using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio5
{
    public abstract class Animal
    {
        public string Nombre { get; private set; } 

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string GetNombre() { return Nombre; }

        public abstract void Comer();
    }
}
