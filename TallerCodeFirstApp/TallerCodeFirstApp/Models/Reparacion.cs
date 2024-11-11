using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerCodeFirstApp.Models
{
    [Table("Reparaciones")]
    public class Reparacion
    {
        [Key]
        public int ReparacionID { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }

        //Parte N de la relacion
        public virtual Vehiculo Vehiculo { get; set; }

        public virtual ICollection<Repuesto> Repuestos { get; set; }

        public virtual ICollection<ReparacionMecanico> ReparacionMecanicos { get; set; }

    }
}