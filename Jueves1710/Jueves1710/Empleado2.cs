using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Empleado2
    {
        private int _edad;
        
        
        public int Edad
        {
            get => _edad; 
            set => _edad = value > 0 ? value : throw new ArgumentException("La edad debe ser mayor que 0");
        }

        public Empleado2(int edad)
        {
            _edad = edad;
        }
    }
}
