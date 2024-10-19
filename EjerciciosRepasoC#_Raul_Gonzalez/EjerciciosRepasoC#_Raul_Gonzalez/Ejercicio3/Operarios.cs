using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoC__Raul_Gonzalez.Ejercicio3
{
    internal class Operarios
    {
        private int[] _sueldos;


        public Operarios()
        {
           _sueldos = new int[5];
            for (int i = 0; i < 5; i++)
            {
               Console.Write("Ingrese el sueldo " + (i+1) + "");
            }

        }


    }
}
