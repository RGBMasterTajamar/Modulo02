using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_Propuesto_2_6_Raul_Gonzalez.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }

        public static List<Contact> CrearLista()
        {
            List<Contact> listaContactos = new List<Contact>();

            listaContactos.Add(new Contact
            {
                FirstName = "Juan",
                LastName = "Belmonte",
                Email = "jb@gmail.com",
                Phone = "(97)1243.23.23",
                DateOfBirth = Convert.ToDateTime("12/07/1990"),
                State = "Alabama"
            });

            listaContactos.Add(new Contact
            {
                FirstName = "Jose",
                LastName = "Escribano",
                Email = "jes@gmail.com",
                Phone = "(97)1243.23.23",
                DateOfBirth = Convert.ToDateTime("12/09/1991"),
                State = "Texas"
            });

            listaContactos.Add(new Contact
            {
                FirstName = "Maria",
                LastName = "Guzman",
                Email = "mg@gmail.com",
                Phone = "(97)1243.23.23",
                DateOfBirth = Convert.ToDateTime("19/12/1995"),
                State = "New Mexico"
            });

            listaContactos.Add(new Contact
            {
                FirstName = "Alberto",
                LastName = "Perez",
                Email = "ap@gmail.com",
                Phone = "(97)1243.23.23",
                DateOfBirth = Convert.ToDateTime("05/05/1985"),
                State = "New Mexico"
            });

            listaContactos.Add(new Contact
            {
                FirstName = "Marcos",
                LastName = "Perez",
                Email = "alguien@gmail.com",
                Phone = "(97)1243.23.23",
                DateOfBirth = Convert.ToDateTime("05/05/1990"),
                State = "Alabama"
            });

            return listaContactos;
        }
    }


}