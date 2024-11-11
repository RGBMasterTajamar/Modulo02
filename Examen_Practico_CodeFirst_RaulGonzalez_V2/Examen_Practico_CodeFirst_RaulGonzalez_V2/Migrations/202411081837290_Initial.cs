namespace Examen_Practico_CodeFirst_RaulGonzalez_V2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accidentes",
                c => new
                    {
                        AccidenteID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Hour = c.DateTime(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.AccidenteID);
            
            CreateTable(
                "dbo.PersonasAccidentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccidenteID = c.Int(nullable: false),
                        PersonaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accidentes", t => t.AccidenteID, cascadeDelete: true)
                .ForeignKey("dbo.Personas", t => t.PersonaID, cascadeDelete: true)
                .Index(t => t.AccidenteID)
                .Index(t => t.PersonaID);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Phone = c.String(),
                        DNI = c.String(),
                    })
                .PrimaryKey(t => t.PersonaID);
            
            CreateTable(
                "dbo.Vehiculos",
                c => new
                    {
                        VehiculoID = c.Int(nullable: false, identity: true),
                        VehicleMat = c.String(),
                        VehicleModel = c.String(),
                        VehicleBrand = c.String(),
                        PersonaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehiculoID)
                .ForeignKey("dbo.Personas", t => t.PersonaID, cascadeDelete: true)
                .Index(t => t.PersonaID);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        MultaID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Hour = c.DateTime(nullable: false),
                        Location = c.String(),
                        Amount = c.Int(nullable: false),
                        VehiculoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MultaID)
                .ForeignKey("dbo.Vehiculos", t => t.VehiculoID, cascadeDelete: true)
                .Index(t => t.VehiculoID);
            
            CreateTable(
                "dbo.VehiculoAccidente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehiculoID = c.Int(nullable: false),
                        AccidenteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accidentes", t => t.AccidenteID, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculos", t => t.VehiculoID, cascadeDelete: true)
                .Index(t => t.VehiculoID)
                .Index(t => t.AccidenteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehiculoAccidente", "VehiculoID", "dbo.Vehiculos");
            DropForeignKey("dbo.VehiculoAccidente", "AccidenteID", "dbo.Accidentes");
            DropForeignKey("dbo.Vehiculos", "PersonaID", "dbo.Personas");
            DropForeignKey("dbo.Multas", "VehiculoID", "dbo.Vehiculos");
            DropForeignKey("dbo.PersonasAccidentes", "PersonaID", "dbo.Personas");
            DropForeignKey("dbo.PersonasAccidentes", "AccidenteID", "dbo.Accidentes");
            DropIndex("dbo.VehiculoAccidente", new[] { "AccidenteID" });
            DropIndex("dbo.VehiculoAccidente", new[] { "VehiculoID" });
            DropIndex("dbo.Multas", new[] { "VehiculoID" });
            DropIndex("dbo.Vehiculos", new[] { "PersonaID" });
            DropIndex("dbo.PersonasAccidentes", new[] { "PersonaID" });
            DropIndex("dbo.PersonasAccidentes", new[] { "AccidenteID" });
            DropTable("dbo.VehiculoAccidente");
            DropTable("dbo.Multas");
            DropTable("dbo.Vehiculos");
            DropTable("dbo.Personas");
            DropTable("dbo.PersonasAccidentes");
            DropTable("dbo.Accidentes");
        }
    }
}
