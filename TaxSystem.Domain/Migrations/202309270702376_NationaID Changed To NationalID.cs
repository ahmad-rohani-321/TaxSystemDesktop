namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NationaIDChangedToNationalID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Owners", "NationalID", c => c.String());
            DropColumn("dbo.Owners", "NationaID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Owners", "NationaID", c => c.String());
            DropColumn("dbo.Owners", "NationalID");
        }
    }
}
