using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MiTiendaProductosApp.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}