using EjerciciosPOO_Raul_Gonzalez.Ejercicio1;
using EjerciciosPOO_Raul_Gonzalez.Ejercicio4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            //int total = 3;
            //Persona[] perosnas = new Persona[total];

            //for (int i = 0; i < total; i++) 
            //{
            //    personas[i] = new Persona();
            //    perosnas[i].NOMBRE

            //}




            // Ejercicio 4
            Coche coche = new Coche(0);
            coche.Conducir();
            Console.Write("Introduzca la carga a repostar: ");
            int gasolina = Convert.ToInt32(Console.ReadLine());
            coche.Repostar(gasolina);
            coche.Conducir();



            Console.ReadKey();
        }

       
    }
}
