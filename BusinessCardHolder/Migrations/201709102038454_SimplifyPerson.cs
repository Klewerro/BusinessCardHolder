namespace BusinessCardHolder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimplifyPerson : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "Forname");
            DropColumn("dbo.People", "Phone");
            DropColumn("dbo.People", "CellPhone");
            DropColumn("dbo.People", "Email");
            DropColumn("dbo.People", "BithDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "BithDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "Email", c => c.String());
            AddColumn("dbo.People", "CellPhone", c => c.String(maxLength: 11));
            AddColumn("dbo.People", "Phone", c => c.String(maxLength: 9));
            AddColumn("dbo.People", "Forname", c => c.String(maxLength: 30));
        }
    }
}
