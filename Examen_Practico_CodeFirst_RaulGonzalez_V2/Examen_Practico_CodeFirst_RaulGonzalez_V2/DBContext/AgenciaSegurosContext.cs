using Examen_Practico_CodeFirst_RaulGonzalez_V2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.DBContext
{
    public class AgenciaSegurosContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<Accidente> Accidentes { get; set; }
        public DbSet<VehiculoAccidente> VehiculoAccidentes { get; set; }
        public DbSet<PersonaAccidente> PersonaAccidentes { get; set; }

        public AgenciaSegurosContext(): base("cadenaDbContext") { }

        
    }
}