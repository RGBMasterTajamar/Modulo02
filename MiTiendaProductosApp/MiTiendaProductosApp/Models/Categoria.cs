using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MiTiendaProductosApp.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Nombre { get;set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}