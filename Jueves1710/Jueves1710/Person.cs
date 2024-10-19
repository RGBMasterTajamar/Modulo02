using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves1710
{
    internal class Person
    {
        protected string ssn = "444-55-6666";
        protected string name = "Jhon L. Malgraine";

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"SSN: {ssn}");
        }

    }
}
