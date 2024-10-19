using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Circulo : Formas
    {
        public Circulo(double radio):base(radio,0) {}
        public override double Area()
        {
            return pi * _x * _x;
        }
    }
}
