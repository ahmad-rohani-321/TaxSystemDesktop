namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetnametodomainPropertyInfofromAttributes : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PropertyInfoes", newName: "PropertyInfo");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.PropertyInfo", newName: "PropertyInfoes");
        }
    }
}
