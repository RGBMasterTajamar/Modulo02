using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Viernes2510App.Models
{
    public class PartesMotor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static List<PartesMotor> CrearPartes() 
        {
            List<PartesMotor> partesMotor = new List<PartesMotor>
            {
                new PartesMotor {Id = 1,Nombre = "Correa de distribucion"},
                new PartesMotor {Id = 2,Nombre = "Arbol de levas" },
                new PartesMotor {Id = 3,Nombre = "Piston" },
                new PartesMotor {Id = 4,Nombre = ",Biela" },
                new PartesMotor {Id = 5,Nombre = "Carter" },
                new PartesMotor {Id = 6,Nombre = "Volante Motor" }
            };
            
            return partesMotor;
        }
    }
}
