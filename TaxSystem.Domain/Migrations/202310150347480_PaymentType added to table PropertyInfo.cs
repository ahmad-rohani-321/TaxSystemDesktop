namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentTypeaddedtotablePropertyInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyInfoes", "PaymentTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.PropertyInfoes", "PaymentTypeId");
            AddForeignKey("dbo.PropertyInfoes", "PaymentTypeId", "dbo.PaymentTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyInfoes", "PaymentTypeId", "dbo.PaymentTypes");
            DropIndex("dbo.PropertyInfoes", new[] { "PaymentTypeId" });
            DropColumn("dbo.PropertyInfoes", "PaymentTypeId");
        }
    }
}
