using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.Models
{
    [Table("Accidentes")]
    public class Accidente
    {
        [Key]
        public int AccidenteID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Location { get; set; }

        public virtual ICollection<PersonaAccidente> PersonaAccidente { get; set; }
        public virtual ICollection<VehiculoAccidente> VehiculoAccidente { get; set; }


    }
}