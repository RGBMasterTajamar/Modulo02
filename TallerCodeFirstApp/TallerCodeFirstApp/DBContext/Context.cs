using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TallerCodeFirstApp.Models;

namespace TallerCodeFirstApp.DBContext
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<ReparacionMecanico> ReparacionesMecanicos { get; set; }

        public Context():base("cadenaDbContext") {}
        /*
            Comandos para usar las migraciones
            1º -> Enable-Migrations
            2º -> add-migration NombreMigracion
            3º -> update-database
         */

    }
}