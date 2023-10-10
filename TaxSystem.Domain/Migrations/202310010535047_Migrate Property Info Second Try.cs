namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigratePropertyInfoSecondTry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                        PropertyOwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.PropertyOwnerId, cascadeDelete: true)
                .Index(t => t.PropertyOwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyInfoes", "PropertyOwnerId", "dbo.Owners");
            DropIndex("dbo.PropertyInfoes", new[] { "PropertyOwnerId" });
            DropTable("dbo.PropertyInfoes");
        }
    }
}