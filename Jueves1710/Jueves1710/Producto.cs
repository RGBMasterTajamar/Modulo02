using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Producto
    {
        private decimal _precio;

        public decimal Precio {
            get =>_precio; 
            set => _precio = value;
        }

        public Producto(decimal precio)
        {
            _precio = precio;
        }
    }
}
