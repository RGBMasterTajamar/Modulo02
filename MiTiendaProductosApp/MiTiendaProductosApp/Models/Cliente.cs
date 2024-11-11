using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MiTiendaProductosApp.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
    }
}