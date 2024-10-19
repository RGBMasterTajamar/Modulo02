using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Porton : Puerta
    {
        public bool Bloqueado { get; set; }

        public void Bloquear()
        {
            Bloqueado = true;
        }
        public void Desbloquear()
        {
            Bloqueado =false;
        }

        public new void MostrarEstado()
        {
            Console.WriteLine($"El ancho del porton es {Ancho} ");
            Console.WriteLine($"El alto del porton es {Alto} ");
            Console.WriteLine($"El color del porton es {Color} ");
            Console.WriteLine($"Abierto? {Abierta} ");
            Console.WriteLine($"Bloqueado? {Bloqueado} ");


        }
    }
}
