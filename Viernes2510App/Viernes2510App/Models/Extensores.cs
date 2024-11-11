using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viernes2510App.Models
{
    public static class Extensores
    {
        public static string ObtenerNombreCompleto(this Persona persona)
        {
            return $"{persona.Nombre}, {persona.Apellido} ";
        }

        public static void Imprimir<T>(this List<T> lista) {
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ImprimirHasta(this int valor, int fin)
        {
            for (var inicio = valor; inicio <= fin; inicio++)
            {

            }
        }
    }
}