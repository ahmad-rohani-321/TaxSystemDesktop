namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abooleanpropertyaddedtoCurrentOwners : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CurrentOwners", "IsCurrent", c => c.Boolean(nullable: false));
            AlterColumn("dbo.CurrentOwners", "Name", c => c.String());
            AlterColumn("dbo.CurrentOwners", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CurrentOwners", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.CurrentOwners", "Name", c => c.String(nullable: false));
            DropColumn("dbo.CurrentOwners", "IsCurrent");
        }
    }
}
