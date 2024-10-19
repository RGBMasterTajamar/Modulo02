using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    abstract class Formas
    {
        public const double pi = Math.PI;
        protected double _x, _y;

        public Formas(double x, double y) {
            _x = x;
            _y = y;
        }

        public abstract double Area();
    }
}
