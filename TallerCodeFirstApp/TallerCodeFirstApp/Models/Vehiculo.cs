using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerCodeFirstApp.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        [Key]
        public int VehiculoId { get; set; }
        public string Matricula { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        // parte N de la relacion 
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }

        // Parte 1 de la relacion
        public virtual ICollection<Reparacion> Reparacion { get; set; }
    }
}