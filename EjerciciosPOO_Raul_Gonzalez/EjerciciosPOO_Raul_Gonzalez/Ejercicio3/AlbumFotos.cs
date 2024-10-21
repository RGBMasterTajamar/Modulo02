using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO_Raul_Gonzalez.Ejercicio3
{
    internal class AlbumFotos
    {
        private int _numPaginas;

        // Constructor por defecto
        public AlbumFotos() {
            _numPaginas = 16;
        }

        // Constuctor adicional
        public AlbumFotos(int numPaginas) { 
            _numPaginas = numPaginas;
        }

        // Metodos
        public int GetNumeroPaginas()
        {
           return _numPaginas;
        }
    }
}
