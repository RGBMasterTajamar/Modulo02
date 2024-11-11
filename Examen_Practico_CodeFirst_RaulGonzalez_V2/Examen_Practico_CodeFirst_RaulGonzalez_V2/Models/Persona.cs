using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.Models
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int PersonaID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string DNI { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
        //public virtual ICollection<Multa> Multas { get; set; }
        public virtual ICollection<PersonaAccidente> PersonaAccidente { get; set; }

    }
}