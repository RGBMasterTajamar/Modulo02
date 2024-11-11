using MiTiendaProductosApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MiTiendaProductosApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Deshabilita cualquier inicializador que intente verificar la compatibilidad del modelo
            Database.SetInitializer<ContextoDatos>(null);

            using (var context = new ContextoDatos())
            {
                if (!context.Categorias.Any())
                {
                    SeedDatabase(context);
                }
            }
        }

        private void SeedDatabase(ContextoDatos context)
        {
            // Semilla para la tabla Categorias
            var categorias = new List<Categoria>
            {
                new Categoria { Nombre = "Electrónica", Descripcion = "Productos electrónicos y accesorios" },
                new Categoria { Nombre = "Hogar", Descripcion = "Productos para el hogar y decoración" },
                new Categoria { Nombre = "Juguetes", Descripcion = "Juguetes y juegos para niños" }
            };

            context.Categorias.AddRange(categorias);
            context.SaveChanges();  // Asegúrate de que las categorías se guardan primero

            // Verifica si las categorías se insertaron correctamente
            var categoriasGuardadas = context.Categorias.ToList();
            if (!categoriasGuardadas.Any())
            {
                throw new Exception("No se insertaron categorías en la base de datos.");
            }

            // Semilla para la tabla Productos
            var productos = new List<Producto>
            {
                new Producto { Nombre = "Smartphone", Precio = 299.99m, CategoriaID = categoriasGuardadas[0].CategoriaID },
                new Producto { Nombre = "Laptop", Precio = 899.99m, CategoriaID = categoriasGuardadas[0].CategoriaID },
                new Producto { Nombre = "Aspiradora", Precio = 150.00m, CategoriaID = categoriasGuardadas[1].CategoriaID },
                new Producto { Nombre = "Lámpara de Mesa", Precio = 35.50m, CategoriaID = categoriasGuardadas[1].CategoriaID },
                new Producto { Nombre = "Osito de Peluche", Precio = 19.99m, CategoriaID = categoriasGuardadas[2].CategoriaID },
                new Producto { Nombre = "Puzzle 3D", Precio = 25.99m, CategoriaID = categoriasGuardadas[2].CategoriaID }
            };

            context.Productos.AddRange(productos);
            context.SaveChanges();  // Asegúrate de que los productos se guardan después de las categorías

            // Verifica si los productos se insertaron correctamente
            var productosGuardados = context.Productos.ToList();
            if (!productosGuardados.Any())
            {
                throw new Exception("No se insertaron productos en la base de datos.");
            }

            // Semilla para la tabla Clientes
            var clientes = new List<Cliente>
            {
                new Cliente { Nombre = "Carlos Pérez", Email = "carlos.perez@example.com" },
                new Cliente { Nombre = "Ana García", Email = "ana.garcia@example.com" },
                new Cliente { Nombre = "Luis Martínez", Email = "luis.martinez@example.com" }
            };

            context.Clientes.AddRange(clientes);
            context.SaveChanges();  // Asegúrate de que los clientes se guardan correctamente

            // Verifica si los clientes se insertaron correctamente
            var clientesGuardados = context.Clientes.ToList();
            if (!clientesGuardados.Any())
            {
                throw new Exception("No se insertaron clientes en la base de datos.");
            }
        }
    }
}