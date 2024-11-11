using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int ClientID { get; set; } // Propiedad para almacenar la FK
        public virtual Client Client { get; set; } // Propiedad de nevgación para guardar el 1 en el N
    }
}