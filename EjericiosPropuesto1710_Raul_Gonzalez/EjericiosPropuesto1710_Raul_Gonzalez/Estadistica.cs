using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericiosPropuesto1710_Raul_Gonzalez
{
    internal class Estadistica
    {

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Numero3 { get; set; }

        // Constructor
        public Estadistica (int num1, int num2, int num3) {
            Numero1 = num1;
            Numero2 = num2;
            Numero3 = num3;
        }


        // Metodos Suma y Media
        public int Suma()
        {
            int result = Numero1 + Numero2 + Numero3;
            return result;
        }

        public decimal Media()
        {
            int suma = Numero1 + Numero2 + Numero3;
            int result = suma / 3;
            return result;
        }

    }
}
