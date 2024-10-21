using EjerciciosPOO_Raul_Gonzalez.Ejercicio1;
using EjerciciosPOO_Raul_Gonzalez.Ejercicio2;
using EjerciciosPOO_Raul_Gonzalez.Ejercicio3;
using EjerciciosPOO_Raul_Gonzalez.Ejercicio4;
using EjerciciosPOO_Raul_Gonzalez.Ejercicio5;
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
            /**************************************************************************************************/
            // Ejercicio 1
            int total = 3;
            Persona[] persona = new Persona[total];

            for (int i = 0; i < total; i++)
            {
                Console.Write($"Persona{i + 1} : ");
                persona[i] = new Persona();
                persona[i].Nombre = Console.ReadLine();
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persona[i].ToString());
            }

            /**************************************************************************************************/
            // Ejercicio 2
            // Crear una nueva Persona y hacer que salude
            Personas personas = new Personas();
            personas.Saludar();

            // Crear un nuevo Estudiante
            Estudiante estudiante = new Estudiante();
            estudiante.AsignarEdad(25); // Asignar una edad
            estudiante.Saludar(); // Saludar
            estudiante.VerEdad(); // Mostrar su edad
            estudiante.Estudiar(); // Comenzar a estudiar

            // Crear un nuevo Profesor
            Profesor profesor = new Profesor();
            profesor.AsignarEdad(55); // Asignar una edad
            profesor.Saludar(); // Saludar
            profesor.Explicar(); // Comenzar la explicación

            /**************************************************************************************************/
            // Ejercicio 3
            // Crear un álbum de fotos predeterminado y mostrar el número de páginas
            AlbumFotos album1 = new AlbumFotos();
            Console.WriteLine("Número de páginas del álbum predeterminado: " + album1.GetNumeroPaginas());

            // Crear un álbum de fotos con 24 páginas y mostrar el número de páginas
            AlbumFotos album2 = new AlbumFotos(24);
            Console.WriteLine("Número de páginas del álbum con 24 páginas: " + album2.GetNumeroPaginas());

            // Crear un gran álbum de fotos y mostrar el número de páginas
            SuperAlbumFotos superAlbum = new SuperAlbumFotos();
            Console.WriteLine("Número de páginas del gran álbum: " + superAlbum.GetNumeroPaginas());

            /**************************************************************************************************/

            // Ejercicio 4
            // Crear un coche y llamar al metodo Conducir()
            Coche coche = new Coche(0);
            coche.Conducir();
            
            // Pedir la carga del repostaje y llamar al metodo Conducir()
            Console.Write("Introduzca la carga a repostar: ");
            int gasolina = Convert.ToInt32(Console.ReadLine());
            coche.Repostar(gasolina);
            coche.Conducir();

            /**************************************************************************************************/

            // Ejercicio 5
            // Solicitar un nombre de perro al usuario
            Console.Write("Introduce el nombre del perro: ");
            string nombrePerro = Console.ReadLine();

            // Crear un nuevo objeto de tipo Perro
            Perro perro = new Perro();
            perro.SetNombre(nombrePerro);

            // Ejecutar los métodos GetNombre y Comer
            Console.WriteLine("El nombre del perro es: " + perro.GetNombre());
            perro.Comer();

            Console.ReadKey();
        }

       
    }
}
