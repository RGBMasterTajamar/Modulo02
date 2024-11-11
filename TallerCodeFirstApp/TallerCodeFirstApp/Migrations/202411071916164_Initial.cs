namespace TallerCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        ClienteName = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Vehiculos",
                c => new
                    {
                        VehiculoId = c.Int(nullable: false, identity: true),
                        Matricula = c.String(),
                        Modelo = c.String(),
                        Color = c.String(),
                        ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehiculoId)
                .ForeignKey("dbo.Clientes", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Reparaciones",
                c => new
                    {
                        ReparacionID = c.Int(nullable: false, identity: true),
                        FechaEntrada = c.DateTime(nullable: false),
                        HoraEntrada = c.DateTime(nullable: false),
                        HoraSalida = c.DateTime(nullable: false),
                        Vehiculo_VehiculoId = c.Int(),
                    })
                .PrimaryKey(t => t.ReparacionID)
                .ForeignKey("dbo.Vehiculos", t => t.Vehiculo_VehiculoId)
                .Index(t => t.Vehiculo_VehiculoId);
            
            CreateTable(
                "dbo.ReparacionesMecanicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EsPrincipal = c.Boolean(),
                        MecanicoID = c.Int(nullable: false),
                        ReparacionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mecanicos", t => t.MecanicoID, cascadeDelete: true)
                .ForeignKey("dbo.Reparaciones", t => t.ReparacionID, cascadeDelete: true)
                .Index(t => t.MecanicoID)
                .Index(t => t.ReparacionID);
            
            CreateTable(
                "dbo.Mecanicos",
                c => new
                    {
                        MecanicoId = c.Int(nullable: false, identity: true),
                        MecanicoName = c.String(),
                        PrecioHora = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MecanicoId);
            
            CreateTable(
                "dbo.Repuestos",
                c => new
                    {
                        RepuestoID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RepuestoID);
            
            CreateTable(
                "dbo.RepuestoReparacions",
                c => new
                    {
                        Repuesto_RepuestoID = c.Int(nullable: false),
                        Reparacion_ReparacionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Repuesto_RepuestoID, t.Reparacion_ReparacionID })
                .ForeignKey("dbo.Repuestos", t => t.Repuesto_RepuestoID, cascadeDelete: true)
                .ForeignKey("dbo.Reparaciones", t => t.Reparacion_ReparacionID, cascadeDelete: true)
                .Index(t => t.Repuesto_RepuestoID)
                .Index(t => t.Reparacion_ReparacionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reparaciones", "Vehiculo_VehiculoId", "dbo.Vehiculos");
            DropForeignKey("dbo.RepuestoReparacions", "Reparacion_ReparacionID", "dbo.Reparaciones");
            DropForeignKey("dbo.RepuestoReparacions", "Repuesto_RepuestoID", "dbo.Repuestos");
            DropForeignKey("dbo.ReparacionesMecanicos", "ReparacionID", "dbo.Reparaciones");
            DropForeignKey("dbo.ReparacionesMecanicos", "MecanicoID", "dbo.Mecanicos");
            DropForeignKey("dbo.Vehiculos", "ClienteID", "dbo.Clientes");
            DropIndex("dbo.RepuestoReparacions", new[] { "Reparacion_ReparacionID" });
            DropIndex("dbo.RepuestoReparacions", new[] { "Repuesto_RepuestoID" });
            DropIndex("dbo.ReparacionesMecanicos", new[] { "ReparacionID" });
            DropIndex("dbo.ReparacionesMecanicos", new[] { "MecanicoID" });
            DropIndex("dbo.Reparaciones", new[] { "Vehiculo_VehiculoId" });
            DropIndex("dbo.Vehiculos", new[] { "ClienteID" });
            DropTable("dbo.RepuestoReparacions");
            DropTable("dbo.Repuestos");
            DropTable("dbo.Mecanicos");
            DropTable("dbo.ReparacionesMecanicos");
            DropTable("dbo.Reparaciones");
            DropTable("dbo.Vehiculos");
            DropTable("dbo.Clientes");
        }
    }
}
