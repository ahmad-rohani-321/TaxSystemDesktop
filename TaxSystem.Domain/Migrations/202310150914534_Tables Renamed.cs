namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesRenamed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PaymentTypes", newName: "PaymentPeriods");
            RenameColumn(table: "dbo.PropertyInfoes", name: "PaymentTypeId", newName: "PaymentPeriodId");
            RenameIndex(table: "dbo.PropertyInfoes", name: "IX_PaymentTypeId", newName: "IX_PaymentPeriodId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PropertyInfoes", name: "IX_PaymentPeriodId", newName: "IX_PaymentTypeId");
            RenameColumn(table: "dbo.PropertyInfoes", name: "PaymentPeriodId", newName: "PaymentTypeId");
            RenameTable(name: "dbo.PaymentPeriods", newName: "PaymentTypes");
        }
    }
}
