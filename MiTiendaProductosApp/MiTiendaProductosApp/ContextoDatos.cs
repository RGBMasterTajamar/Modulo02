using MiTiendaProductosApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MiTiendaProductosApp
{
    public class ContextoDatos : DbContext
    {
        public ContextoDatos():base("MiTiendaDBEntities1")
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desactiva la pluralizacion de nombres
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}