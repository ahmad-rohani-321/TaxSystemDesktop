namespace TaxSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitailMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FatherName = c.String(),
                        GrandFatherName = c.String(),
                        NationaID = c.String(),
                        PageNo = c.String(),
                        JuldNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
        }
    }
}
