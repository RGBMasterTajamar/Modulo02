using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerCodeFirstApp.Models
{
    [Table("ReparacionesMecanicos")]
    public class ReparacionMecanico
    {
        [Key]
        public int Id { get; set; }
        public bool? EsPrincipal { get; set; }
        public int MecanicoID { get; set; }
        public virtual Mecanico Mecanico { get; set; }
        public int ReparacionID { get; set; }
        public virtual Reparacion Reparacion { get; set; }
    }
}