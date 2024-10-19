using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Program
    {

        // Funciones
        //public static void Saludar ()
        //{
        //    Console.WriteLine("Bienvenido al programa");
        //}


        //public static void EscribeNumeroReal(float n)
        //{
        //    Console.WriteLine (n.ToString ());
        //}

        //public static void Suma(int x, int y)
        //{
        //    Console.WriteLine((x + y).ToString ());
        //}

        //static void duplicar(ref int x)
        //{
        //    Console.WriteLine($"El valor recibido vale {x}");
        //    x *= 2;
        //    Console.WriteLine($"El valor es {x}");
        //}

        //public static int HacerCuadrado(int x)
        //{
        //    return x * x;
        //}

       

        static void Main(string[] args)
        {
            // Clase String();
            // Extraer una subcadena
            //string frase = "Hola mundo Master Bienvendidos al mundo de la programacion";
            //string saludo = frase.Substring(0,4);

            //Console.WriteLine(frase);
            //Console.WriteLine(saludo);


            // buscar en cadenas
            //string buscar = "mundo";
            //int posicion = frase.IndexOf(buscar);
            //Console.WriteLine(posicion);
            //if (posicion != -1)
            //{
            //    Console.WriteLine(buscar);
            //}
            //else { Console.WriteLine("No se ha encontrado la busqueda"); }

            // buscar un caracter 
            //char caracter = 'a';
            //int posicionCaracter = frase.IndexOf(caracter);
            //if (posicionCaracter != -1)
            //{
            //    Console.WriteLine(posicionCaracter);
            //    Console.WriteLine(caracter);
            //}
            //else { Console.WriteLine("No se ha encontrado la busqueda"); }


            // Contains: busca en una cadena si contiene una palabra y retorna un bool
            //string busqueda = "Master";
            //bool existe = frase.Contains(busqueda);

            //if (existe)
            //{
            //    Console.WriteLine(busqueda + " " + existe);
            //}
            //else
            //{
            //    Console.WriteLine("la palabra buscada no ha sido encontrada");
            //}


            // Convertir a cadena generica
            //double valor = 1.222;
            //string valorConvertido = valor.ToString();
            //Console.WriteLine(valorConvertido);


            // Split(): trocea en un array una cadena de caracteres
            //string ejemplo = "uno.dos.tres.cuatro";
            //char[] delimitadores = { ':', ',', '.' };

            //string[] ejemploPartido = ejemplo.Split(delimitadores);
            //for (int i = 0; i < ejemploPartido.Length; i++)
            //{
            //    Console.WriteLine(ejemploPartido[i]);
            //}

            // StringBuilder(): Devuelve la elaboracion de cadena que hay que convertirla despues a string
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hola: ");
            //sb.Append("bienvenido ");
            //sb.Append("al tutorial ");
            //sb.Append("de C#");

            //Console.WriteLine(sb.ToString());
            //// Insertara en una sb
            //sb.Insert(20, "rapido ");
            //Console.WriteLine(sb.ToString());
            //// Reemplazar
            //sb.Replace("bienvenido", "welcome");
            //Console.WriteLine(sb.ToString());
            //// Eliminar
            //sb.Remove(15,20);
            //Console.WriteLine(sb.ToString());



            // forEach
            //int[] numeros = { 1, 2, 3, 4, 5 };

            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}



            // llamada a la funcion
            //Saludar ();
            //EscribeNumeroReal(2.3f);
            //Suma(5, 7);
            //Console.WriteLine(HacerCuadrado(3));
            //int n = 5;
            //Console.WriteLine($"n vale {n}");
            //duplicar(ref n);
            //Console.WriteLine($"Ahora n vale {n}");



            // Math.Floor(): Redondeo hacia abajo
            // Math.Round(): Redondeo hacia arriba
            // Math.Pow(): Potencias recibe dos parametros
            //double base1 = 5;
            //double potencia = 5;

            //double num1 = 31.3;
            //double num2 = 431.5;
            //double num3 = 331.9;
            //double num4 = 1.1;

            //double result1 = Math.Round(num1);
            //double result2 = Math.Round(num2);
            //double result3 = Math.Round(num3);
            //double result4 = Math.Round(num4);
            //double resultPow = Math.Pow(base1, potencia);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);
            //Console.WriteLine(resultPow);


            // Random(): Devuelve un numero aleatorio en un intervalo
            //Random generador = new Random();
            //int randomNum = generador.Next(1, 100);

            //Console.WriteLine(randomNum);


            // Crear un programa que genere un numero al azar entre 1 y 100
            // el usuario tendra 6 oportunidades para acertarlo.
            // Acotar sì es mayor o menor que el numero

            //Random generador = new Random();
            //int randomNum = generador.Next(1, 100);

            //Console.WriteLine("Se ha generado un numero aleatorio entre 1 y 100");
            //Console.WriteLine("Elija 1 y 100");
            //int attemps = 0;
            //int numOpt;

            //while (attemps < 6) {
            //    Console.Write("Numero: ");
            //    numOpt = Convert.ToInt32(Console.ReadLine());
            //    if (numOpt == randomNum) {
            //        Console.WriteLine($"Has hacertado el numero era {randomNum}");
            //        attemps = 6;
            //        break;
            //    }
            //    else
            //    {
            //        if (numOpt > randomNum)
            //        {
            //            Console.WriteLine("Demasiado bajo");
            //            attemps++;
            //        }else if(numOpt < randomNum)
            //        {
            //            Console.WriteLine("Demasiado alto");
            //            attemps++;
            //        }
            //    }

            //}



            // Instanciamos un objeto de la clase Puerta
            //Puerta p1 = new Puerta();
            //p1.Alto = 198;
            //p1.Ancho = 120;
            //p1.Color = 12121;
            //p1.Abierta = true;
            //Console.WriteLine("Valores iniciales...");
            //p1.MostrarEstado();

            // Instanciamos un objeto de la clase Persona
            //Persona persona = new Persona();
            //persona.Nombre = "Raul";
            //persona.FechaNacimiento = new DateTime(2000, 12, 7);
            //persona.Saludar();

            // Porton
            //Porton po1 = new Porton();
            //po1.Ancho = 222;
            //po1.Alto = 455;
            //po1.Color = 12121;
            //po1.Abierta = true;
            //po1.Bloqueado = true;
            //po1.MostrarEstado();

            //Console.WriteLine("Empleado (intro para empleado generico): ");
            //string nombreEmpleado = Console.ReadLine();

            //if (nombreEmpleado.Length == 0)
            //{
            //    Empleado empleadoGenerico = new Empleado();
            //    empleadoGenerico.Imprimir();
            //}else
            //{
            //    Console.Write("Sueldo: ");
            //    int sueldoEmpleado = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Cargo: ");
            //    string cargoEmpleado = Console.ReadLine();

            //    Empleado empleadoGenerico = new Empleado(sueldoEmpleado, nombreEmpleado, cargoEmpleado);
            //}


            //Employee employee = new Employee();
            //employee.GetInfo();

            // Podemos llamar a un constructor de la clase base desde un constructor de la clase derivada
            // RectanguloRelleno --> Rectangulo
            // public RectanguloRelleno (in x, int y) : base(x,y)

            //Coordenadas c1 = new Coordenadas(12,7);
            //Console.WriteLine(c1.ToString());



            // Clase abstracta: No se puede instanciar. Solo se pueden utilizar para generar subclases
            // 
            //double radio = 2.5;
            //double altura = 3.0;

            //Circulo circulo = new Circulo(radio);
            //Cilindro cilindro = new Cilindro(radio,altura);

            //Console.WriteLine($"Area del circulo: {circulo.Area()}");
            //Console.WriteLine($"Area del cilindro: {cilindro.Area()}");


            // Funciones lamda
            //Producto prod1 = new Producto(23.5m);
            //prod1.Precio = 26.5m;


            //Empleado2 empleado = new Empleado2(24);
            //empleado.Edad = 0;
            //Console.WriteLine(empleado.Edad);


            // interfaces: 
            // Define un contrato.

            //Carro carro = new Carro();
            //carro.Frenar();
            //carro.Acelerar();



            Abeja abeja = new Abeja();
            IVolador abejaVolador = abeja as IVolador;
            abejaVolador.Volar();


            Console.ReadKey();

        }
    }
}
