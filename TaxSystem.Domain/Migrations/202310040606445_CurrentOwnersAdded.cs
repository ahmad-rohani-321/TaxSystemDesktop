namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CurrentOwnersAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentOwners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        PropertyOwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PropertyInfoes", t => t.PropertyOwnerId, cascadeDelete: true)
                .Index(t => t.PropertyOwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CurrentOwners", "PropertyOwnerId", "dbo.PropertyInfoes");
            DropIndex("dbo.CurrentOwners", new[] { "PropertyOwnerId" });
            DropTable("dbo.CurrentOwners");
        }
    }
}
