using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericiosPropuesto1710_Raul_Gonzalez
{
    internal class Concatena
    {
        // Declaracion de propiedades
        public string nombre;
        public string apellido;

        // getter y setter
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Constructor
        public Concatena(string nombre, string apellido) {
            Nombre = nombre;
            Apellido = apellido;
        }

        // Metodo
        public string Concatenar ()
        {
            string nombreCompleto = Nombre + " " + Apellido; ;
            return nombreCompleto;
        }
    }
}
