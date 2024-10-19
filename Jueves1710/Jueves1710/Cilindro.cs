using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Cilindro : Circulo
    {
        public Cilindro(double radio, double altura) : base(radio)
        {
            _y = altura;
        }

        public override double Area() { return (2 * base.Area()) + (2 * pi * _x * _y); }
    }
}
