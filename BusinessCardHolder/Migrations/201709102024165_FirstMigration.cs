namespace BusinessCardHolder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        Number = c.Int(nullable: false),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.BusinessCards",
                c => new
                    {
                        BusinessCardId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BusinessCardId)
                .ForeignKey("dbo.Addresses", t => t.BusinessCardId)
                .Index(t => t.BusinessCardId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Forname = c.String(maxLength: 30),
                        Name = c.String(maxLength: 30),
                        Phone = c.String(maxLength: 9),
                        CellPhone = c.String(maxLength: 11),
                        Email = c.String(),
                        BithDate = c.DateTime(nullable: false),
                        BusinessCard_BusinessCardId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.BusinessCards", t => t.BusinessCard_BusinessCardId)
                .Index(t => t.BusinessCard_BusinessCardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "BusinessCard_BusinessCardId", "dbo.BusinessCards");
            DropForeignKey("dbo.BusinessCards", "BusinessCardId", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "BusinessCard_BusinessCardId" });
            DropIndex("dbo.BusinessCards", new[] { "BusinessCardId" });
            DropTable("dbo.People");
            DropTable("dbo.BusinessCards");
            DropTable("dbo.Addresses");
        }
    }
}
