using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepasoC__Raul_Gonzalez.Ejercicio2
{
    internal class Dados
    {
        int _valor;
        private Random _rnd;

        public Dados()
        {
            _rnd = new Random();
        }

        public int Lanzar()
        {
            _valor = _rnd.Next(1, 7);
            return _valor; // Lanza un dado (1 a 6)
        }

    }
}
