namespace BusinessCardHolder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abcd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firms",
                c => new
                    {
                        FirmId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Number = c.Int(nullable: false),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.FirmId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Firm_FirmId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Firms", t => t.Firm_FirmId)
                .Index(t => t.Firm_FirmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Firm_FirmId", "dbo.Firms");
            DropIndex("dbo.People", new[] { "Firm_FirmId" });
            DropTable("dbo.People");
            DropTable("dbo.Firms");
        }
    }
}
