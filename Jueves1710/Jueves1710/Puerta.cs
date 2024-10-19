using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Puerta
    {

        // Encapsulamiento: Ambiro donde sera visible la propiedad
        // Private, Publico, Protected (accesible desde dentro de la clase y de las clases que hereden de ella)


        // Las propiedades privadas siempre llevan un prefijo _
        int _ancho;
        int _alto;
        int _color;
        bool _abierta;

        // Constructor por defecto
        public Puerta()
        {
            Ancho = 100;
            Alto = 200;
            Color = 12121;
            Abierta = false;
        }
        // Constructor 2
        public Puerta (int ancho, int alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        // Constructor 3

        public Puerta(int ancho, int alto, int color)
        {
            Ancho = ancho;
            Alto = alto;
            Color = color;
        }

        public void Abrir()
        {
            Abierta = true;
        }

        public void Cerrar()
        {
            Abierta = false;
        }

        // Getter y Setter
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int Color { get; set; }
        public bool Abierta { get; set; }
        
       
        public void MostrarEstado()
        {
            

            Console.WriteLine($"El ancho de la puerta es: {Ancho}");
            Console.WriteLine($"El alto de la puerta es: {Alto}");
            Console.WriteLine($"El color de la puerta es: {Color}");
            Console.WriteLine($"Abierta?: {Abierta}");
        }
    }
}
