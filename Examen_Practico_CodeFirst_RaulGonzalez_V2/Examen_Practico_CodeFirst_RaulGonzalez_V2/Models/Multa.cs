using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.Models
{
    [Table("Multas")]
    public class Multa
    {
        [Key]
        public int MultaID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Location { get; set; }
        public int Amount { get; set; }

        //public int PersonaID { get; set; }
        //public virtual Persona Persona { get; set; }

        public int VehiculoID { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}