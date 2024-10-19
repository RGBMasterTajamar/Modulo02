using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoC__Raul_Gonzalez.Ejercicio1
{
    internal class Cliente
    {
        string _nombre;
        int _montante;

        public Cliente(string nnombre) 
        {
            _nombre = nnombre;
            _montante = 0;
        }


        public void HacerIngreso(int m) 
        {
            _montante += m;
        }

        public void HacerExtraccion(int m)
        {
            _montante -= m;
        }

        public int RetornarMontante()
        {
            return _montante;
        }

        public void Imprimir()
        {
            Console.WriteLine($"{_nombre} tiene depositado al suma de {_montante}");
        }
    }
}
