using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerCodeFirstApp.Models
{
    [Table("Mecanicos")]
    public class Mecanico
    {
        [Key]
        public int MecanicoId { get; set; }
        public string MecanicoName { get; set; }
        public decimal PrecioHora { get; set; }

        public virtual ICollection<ReparacionMecanico> ReparacionMecanicos { get; set; }
    }
}