using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerCodeFirstApp.Models
{
    [Table("Repuestos")]
    public class Repuesto
    {
        [Key]
        public int RepuestoID { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        // Como es una relacion N:N se crean solo los ICollection
        // Si la tabla generada entre ambas tuviese campos propios 
        // Habria que hacerlo como en las demas
        public virtual ICollection<Reparacion> Reparaciones { get; set; }

    }
}