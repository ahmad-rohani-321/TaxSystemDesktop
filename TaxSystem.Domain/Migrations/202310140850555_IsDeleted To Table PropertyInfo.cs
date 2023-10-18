namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeletedToTablePropertyInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyInfoes", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PropertyInfoes", "IsDeleted");
        }
    }
}
