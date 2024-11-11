namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.Migrations
{
    using Examen_Practico_CodeFirst_RaulGonzalez_V2.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Examen_Practico_CodeFirst_RaulGonzalez_V2.DBContext.AgenciaSegurosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Examen_Practico_CodeFirst_RaulGonzalez_V2.DBContext.AgenciaSegurosContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //var personas = new List<Persona>
            //{
            //   new Persona { FirstName = "Juan", LastName = "Pérez", Address = "Calle 1", City = "Ciudad A", Phone = "123456789", DNI = "12345678X" },
            //    new Persona { FirstName = "Ana", LastName = "Gómez", Address = "Calle 2", City = "Ciudad B", Phone = "987654321", DNI = "98765432Y" },
            //    new Persona { FirstName = "Carlos", LastName = "López", Address = "Calle 3", City = "Ciudad C", Phone = "112233445", DNI = "11223344Z" },
            //    new Persona { FirstName = "Laura", LastName = "Martínez", Address = "Calle 4", City = "Ciudad D", Phone = "223344556", DNI = "22334455W" },
            //    new Persona { FirstName = "David", LastName = "Fernández", Address = "Calle 5", City = "Ciudad E", Phone = "556677889", DNI = "55667788V" }
            //};
            //context.Personas.AddRange(personas);
            //context.SaveChanges();

            //var vehiculos = new List<Vehiculo>
            //{
            //    new Vehiculo { VehicleModel = "Focus", VehicleBrand = "Ford", VehicleMat = "ABC123", PersonaID = 1 },
            //    new Vehiculo { VehicleModel = "X5", VehicleBrand = "BMW", VehicleMat = "DEF456", PersonaID = 2 },
            //    new Vehiculo { VehicleModel = "A4", VehicleBrand = "Audi", VehicleMat = "GHI789", PersonaID = 3 },
            //    new Vehiculo { VehicleModel = "Corolla", VehicleBrand = "Toyota", VehicleMat = "JKL012", PersonaID = 4 },
            //    new Vehiculo { VehicleModel = "Altima", VehicleBrand = "Nissan", VehicleMat = "MNO345", PersonaID = 5 }
            //};
            //context.Vehiculos.AddRange(vehiculos);
            //context.SaveChanges();

            //var accidentes = new List<Accidente>
            //{
            //    new Accidente { Date = new DateTime(2024, 11, 8), Hour = new DateTime(2024, 11, 8, 14, 30, 0), Location = "Calle 1, Ciudad A" },
            //    new Accidente { Date = new DateTime(2024, 11, 8), Hour = new DateTime(2024, 11, 8, 15, 00, 0), Location = "Calle 2, Ciudad B" },
            //    new Accidente { Date = new DateTime(2024, 11, 8), Hour = new DateTime(2024, 11, 8, 16, 00, 0), Location = "Calle 3, Ciudad C" },
            //    new Accidente { Date = new DateTime(2024, 11, 9), Hour = new DateTime(2024, 11, 9, 09, 30, 0), Location = "Avenida Central, Ciudad D" },
            //    new Accidente { Date = new DateTime(2024, 11, 9), Hour = new DateTime(2024, 11, 9, 11, 00, 0), Location = "Carretera Sur, Ciudad E" }
            //};
            //context.Accidentes.AddRange(accidentes);
            //context.SaveChanges();

            //var multas = new List<Multa>
            //{
            //    new Multa { Date = new DateTime(2024, 11, 8), Hour = new DateTime(2024, 11, 8, 10, 30, 0), Location = "Calle 1, Ciudad A", Amount = 100 },
            //    new Multa { Date = new DateTime(2024, 11, 8), Hour = new DateTime(2024, 11, 8, 12, 00, 0), Location = "Calle 2, Ciudad B", Amount = 150 },
            //    new Multa { Date = new DateTime(2024, 11, 8), Hour = new DateTime(2024, 11, 8, 14, 00, 0), Location = "Calle 3, Ciudad C", Amount = 200 },
            //    new Multa { Date = new DateTime(2024, 11, 9), Hour = new DateTime(2024, 11, 9, 09, 30, 0), Location = "Avenida Central, Ciudad D", Amount = 120 },
            //    new Multa { Date = new DateTime(2024, 11, 9), Hour = new DateTime(2024, 11, 9, 11, 00, 0), Location = "Carretera Sur, Ciudad E", Amount = 180 }
            //};
            //context.Multas.AddRange(multas);
            //context.SaveChanges();


            //var accidenteVehiculo = new List<VehiculoAccidente>
            //{
            //    new VehiculoAccidente { VehiculoID = 1, AccidenteID = 1 },
            //    new VehiculoAccidente { VehiculoID = 2, AccidenteID = 2 },
            //    new VehiculoAccidente { VehiculoID = 3, AccidenteID = 3 }
            //};
            //context.VehiculoAccidentes.AddRange(accidenteVehiculo);
            //context.SaveChanges();

            //var accidentePersona = new List<PersonaAccidente>
            //{
            //    new PersonaAccidente { PersonaID = 1, AccidenteID = 1 },
            //    new PersonaAccidente { PersonaID = 2, AccidenteID = 2 },
            //    new PersonaAccidente { PersonaID = 3, AccidenteID = 3 }
            //};
            //context.PersonaAccidentes.AddRange(accidentePersona);
            //context.SaveChanges();
        }
    }
}
