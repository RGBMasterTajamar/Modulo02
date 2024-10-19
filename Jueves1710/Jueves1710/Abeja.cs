using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Abeja : IVolador
    {
        void IVolador.Volar()
        {
            Console.WriteLine("Volando abeja...");
        }
    }
}
