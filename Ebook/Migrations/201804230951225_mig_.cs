namespace Ebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.marks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Group_name = c.String(),
                        Year = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        Action_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EDU_actions", t => t.Action_Id)
                .ForeignKey("dbo.People", t => t.Student_Id)
                .Index(t => t.Action_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.marks", "Student_Id", "dbo.People");
            DropForeignKey("dbo.marks", "Action_Id", "dbo.EDU_actions");
            DropIndex("dbo.marks", new[] { "Student_Id" });
            DropIndex("dbo.marks", new[] { "Action_Id" });
            DropTable("dbo.marks");
        }
    }
}
