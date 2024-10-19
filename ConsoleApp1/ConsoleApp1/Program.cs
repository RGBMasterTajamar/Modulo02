using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static string[] pruebas = { "Prueba1", "Prueba2", "Prueba3", null, null }; // Asegúrate de que el array tenga espacio
        static int capacidadArray = pruebas.Length;
        static int cantidad = 3;

        static void Main(string[] args)
        {


            //BUSCAR, AÑADIR AL FINAL, INSERTAR UNA POSICION, BORRAR

            //int[] datos = { 10, 15, 12, 0, 0 };
            //int capacidadArray = datos.Length;
            //int cantidad = 3;

            //for (int i = 0; i < capacidadArray; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}
            ////BUSCAR UN VALOR : 15
            //for (int i = 0; i < capacidadArray; i++)
            //{
            //    if (datos[i] == 15)
            //        Console.WriteLine($"Encontrado el 15 en la posicion {i + 1}");
            //}
            ////Añadir dato 6 en la primera posicion libre
            //if (cantidad < capacidadArray)
            //{
            //    datos[cantidad] = 6;
            //}
            //cantidad++;


            ////Volvemos a mostrar el array
            //Console.WriteLine("Hemos añadido el 6");
            //for (int i = 0; i < capacidadArray; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}

            ////BORRAMOS UN DATO DETERMINADO: El Segundo
            //Console.WriteLine("Borramos el segundo dato");
            //int posicionBorrar = 1;
            //for (int i = posicionBorrar; i < cantidad; i++)
            //{
            //    datos[i] = datos[i + 1];
            //}
            //cantidad--;

            ////Volvemos a mostrar el array
            //Console.WriteLine("Eliminando el segundo elemento");
            //for (int i = 0; i < capacidadArray; i++)
            //{

            //    Console.WriteLine(datos[i]);
            //}


            ////INSERTAR EN UNA DETERMINADA POSICION 30 en la tercera
            //if (cantidad < capacidadArray)
            //{
            //    Console.WriteLine("Hay hueco insert 30 en la pos 3");
            //    int posicioninsert = 2;
            //    for (int i = cantidad; i > posicioninsert; i--)
            //    {
            //        datos[i] = datos[i - 1];
            //    }
            //    datos[posicioninsert] = 30;
            //    cantidad++;
            //}
            ////Volvemos a mostrar el array
            //Console.WriteLine("con el nuevo elemento 30");
            //for (int i = 0; i < capacidadArray; i++)
            //{

            //    Console.WriteLine(datos[i]);
            //}


            //Console.ReadKey();


            Console.WriteLine("************************************************");
            Console.WriteLine("1. Añadir Dato");
            Console.WriteLine("2. Insertar en una determinada posicion");
            Console.WriteLine("3. Borrar dato en una determinada posicion");
            Console.WriteLine("4. Mostrar datos del Array");
            Console.WriteLine("5. Salir");
            Console.WriteLine("************************************************");

            int numCaso = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("1. Añadir Dato");
                Console.WriteLine("2. Insertar en una determinada posicion");
                Console.WriteLine("3. Borrar dato en una determinada posicion");
                Console.WriteLine("4. Mostrar datos del Array");
                Console.WriteLine("5. Salir");
                Console.WriteLine("************************************************");

                numCaso = Convert.ToInt32(Console.ReadLine());

                switch (numCaso)
                {
                    case 1:
                        if (cantidad < capacidadArray)
                        {
                            pruebas[cantidad] = "Prueba4";
                            cantidad++;
                        }
                        break;
                    case 2:
                        if (cantidad < capacidadArray)
                        {
                            Console.WriteLine("Hay hueco para insertar Prueba5 en la pos 2");
                            int posInsertar = 2;
                            for (int i = cantidad; i > posInsertar; i--)
                            {
                                pruebas[i] = pruebas[i - 1];
                            }
                            pruebas[posInsertar] = "Prueba5";
                            cantidad++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Borramos el segundo dato");
                        int posicionBorrar = 1;
                        for (int i = posicionBorrar; i < cantidad - 1; i++)
                        {
                            pruebas[i] = pruebas[i + 1];
                        }
                        pruebas[cantidad - 1] = null; // Limpiar el último elemento
                        cantidad--;
                        break;
                    case 4:
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(pruebas[i]);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Seleccionado salir");
                        break;
                }

               
            } while (numCaso != 5);
            Console.ReadKey();

        }
    }
}
