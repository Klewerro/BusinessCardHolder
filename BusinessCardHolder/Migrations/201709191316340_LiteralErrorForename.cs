namespace BusinessCardHolder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LiteralErrorForename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Forename", c => c.String());
            DropColumn("dbo.People", "Forname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Forname", c => c.String());
            DropColumn("dbo.People", "Forename");
        }
    }
}
