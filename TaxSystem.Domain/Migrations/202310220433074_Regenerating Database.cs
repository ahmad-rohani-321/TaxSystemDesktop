namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegeneratingDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentOwners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsCurrent = c.Boolean(nullable: false),
                        Name = c.String(),
                        Phone = c.String(),
                        PropertyOwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PropertyInfo", t => t.PropertyOwnerId, cascadeDelete: true)
                .Index(t => t.PropertyOwnerId);
            
            CreateTable(
                "dbo.PropertyInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LicenseNumber = c.String(maxLength: 100),
                        Location = c.String(),
                        Longtitude = c.String(),
                        Lantitude = c.String(),
                        West = c.String(),
                        East = c.String(),
                        South = c.String(),
                        North = c.String(),
                        District = c.String(),
                        Parcel = c.String(),
                        Block = c.String(),
                        TaxAmount = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        PropertyLevelId = c.Int(nullable: false),
                        PropertyOwnerId = c.Int(nullable: false),
                        PaymentPeriodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PropertyLevels", t => t.PropertyLevelId, cascadeDelete: true)
                .ForeignKey("dbo.Owners", t => t.PropertyOwnerId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentPeriods", t => t.PaymentPeriodId, cascadeDelete: true)
                .Index(t => t.LicenseNumber, unique: true)
                .Index(t => t.PropertyLevelId)
                .Index(t => t.PropertyOwnerId)
                .Index(t => t.PaymentPeriodId);
            
            CreateTable(
                "dbo.PropertyLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LevelName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FatherName = c.String(),
                        GrandFatherName = c.String(),
                        NationalID = c.String(),
                        PageNo = c.String(),
                        JuldNo = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentPeriods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CurrentOwners", "PropertyOwnerId", "dbo.PropertyInfo");
            DropForeignKey("dbo.PropertyInfo", "PaymentPeriodId", "dbo.PaymentPeriods");
            DropForeignKey("dbo.PropertyInfo", "PropertyOwnerId", "dbo.Owners");
            DropForeignKey("dbo.PropertyInfo", "PropertyLevelId", "dbo.PropertyLevels");
            DropIndex("dbo.PropertyInfo", new[] { "PaymentPeriodId" });
            DropIndex("dbo.PropertyInfo", new[] { "PropertyOwnerId" });
            DropIndex("dbo.PropertyInfo", new[] { "PropertyLevelId" });
            DropIndex("dbo.PropertyInfo", new[] { "LicenseNumber" });
            DropIndex("dbo.CurrentOwners", new[] { "PropertyOwnerId" });
            DropTable("dbo.PaymentPeriods");
            DropTable("dbo.Owners");
            DropTable("dbo.PropertyLevels");
            DropTable("dbo.PropertyInfo");
            DropTable("dbo.CurrentOwners");
        }
    }
}
