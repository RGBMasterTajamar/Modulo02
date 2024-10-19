using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericiosPropuesto1710_Raul_Gonzalez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 3.6
            Console.Write("Escriba su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Escriba su Apellido: ");
            var apellido = Console.ReadLine();

            Concatena con = new Concatena(nombre, apellido);
            Console.WriteLine(con.Concatenar());


            // Ejercicio 3.7
            int[] valores = new int[3];
            for (int i = 0; i < valores.Length; i++) { 
                Console.WriteLine($"Valor de x {i+1}");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            Estadistica est1 = new Estadistica(valores); // Revisar
            Console.WriteLine(est1.Suma());
            Console.WriteLine(est1.Media());


            Console.ReadKey();


        }
    }
}
