using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viernes2510App.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {Name}";
        }
        public static List<Clientes> CrearClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            Clientes clientes1 = new Clientes();
            clientes1.Id = 1;
            clientes1.Name = "Andres";
            clientes1.LastName = "Gomez";
            clientes1.FullName = clientes1.ToString();

            clientes.Add(clientes1);

            
            Clientes clientes2 = new Clientes();
            clientes2.Id = 2;
            clientes2.Name = "Sara";
            clientes2.LastName = "Gonzalez";
            clientes2.FullName = clientes2.ToString();
            clientes.Add(clientes2);

            return clientes ;
        }


    }
}