namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigratePoropertyInfonewpropertiesandPropertyLevelEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyLevels",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        LevelName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PropertyInfoes", "TaxAmount", c => c.Int(nullable: false));
            AddColumn("dbo.PropertyInfoes", "PropertyLevelId", c => c.Int(nullable: false));
            CreateIndex("dbo.PropertyInfoes", "PropertyLevelId");
            AddForeignKey("dbo.PropertyInfoes", "PropertyLevelId", "dbo.PropertyLevels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyInfoes", "PropertyLevelId", "dbo.PropertyLevels");
            DropIndex("dbo.PropertyInfoes", new[] { "PropertyLevelId" });
            DropColumn("dbo.PropertyInfoes", "PropertyLevelId");
            DropColumn("dbo.PropertyInfoes", "TaxAmount");
            DropTable("dbo.PropertyLevels");
        }
    }
}
