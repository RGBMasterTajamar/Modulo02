using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiTiendaProductosApp.Back
{
    public partial class Servicios : System.Web.UI.Page
    {
        private static MiTiendaDBEntities1 db = new MiTiendaDBEntities1();

        [WebMethod]
        public static object CreateProducto(string nombre, decimal precio, int categoriaId)
        {
            try
            {
                var producto = new Productos
                {
                    Nombre = nombre,
                    Precio = precio,
                    CategoriaId = categoriaId
                };
                db.Productos.Add(producto);
                db.SaveChanges();

                return new { success = true };
            }
            catch (Exception ex)
            {
                return new { success = false, message = ex.Message };
                throw;
            }
        }

        [WebMethod]
        public static object GetProductos()
        {
            var products = db.Productos.Select(p => new
            {
                p.ProductoId,
                p.Nombre,
                p.Precio,
                Categoria = p.Categorias.Nombre
            }).ToList();

            return products;
        }

        [WebMethod]
        public static object EditarProductos() { return true; }

        [WebMethod]
        public static object DeleteProduct(int productoId) 
        {
            try
            {
                var producto = db.Productos.Find(productoId);
                if (producto == null)
                {
                    return new { success = false, message = "Producto no encontrado" };
                }
                db.Productos.Remove(producto);
                db.SaveChanges();
                return new { success = true };
            }
            catch (Exception ex)
            {
                return new {success = false, message = ex.Message};
                throw;
            }
        }


        [WebMethod]
        public static object ObtenerCategorias()
        {
            var categorias = db.Categorias.Select(c => new
            {
                c.CategoriaId,
                c.Nombre
            }).ToList();

            return categorias;
        }
    }
}