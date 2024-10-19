using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Coordenadas
    {
        private int _x, _y;

        // Primer constructor
        public Coordenadas()
        {
            _x = 0; _y = 0;
        }

        // Segundo constructor
        public Coordenadas(int x, int y)
        {
            _x = x; _y = y;
        }


        public override string ToString()
        {
            return (String.Format("{0},{1}",_x,_y));
        }
    }
}
