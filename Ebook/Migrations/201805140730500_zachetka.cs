namespace Ebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zachetka : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "zachentka", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "zachentka");
        }
    }
}
