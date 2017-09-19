namespace BusinessCardHolder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Forname", c => c.String());
            AddColumn("dbo.People", "Phone", c => c.String());
            AddColumn("dbo.People", "CellPhone", c => c.String());
            AddColumn("dbo.People", "Email", c => c.String());
            AddColumn("dbo.People", "BithDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.People", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Name", c => c.String(maxLength: 30));
            DropColumn("dbo.People", "BithDate");
            DropColumn("dbo.People", "Email");
            DropColumn("dbo.People", "CellPhone");
            DropColumn("dbo.People", "Phone");
            DropColumn("dbo.People", "Forname");
        }
    }
}
