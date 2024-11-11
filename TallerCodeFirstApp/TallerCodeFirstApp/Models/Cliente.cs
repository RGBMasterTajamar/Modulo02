using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerCodeFirstApp.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string DNI {  get; set; }
        public string ClienteName { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }

        // Parte de la relacion 1
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }

    }
}