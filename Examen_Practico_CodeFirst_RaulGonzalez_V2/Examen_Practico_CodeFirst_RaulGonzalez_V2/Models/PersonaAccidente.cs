using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.Models
{
    [Table("PersonasAccidentes")]
    public class PersonaAccidente
    {
        [Key]
        public int Id { get; set; }
        public int AccidenteID { get; set; }
        public virtual Accidente Accidente { get; set; }
        public int PersonaID { get; set; }
        public virtual Persona Persona { get; set; }
    }
}