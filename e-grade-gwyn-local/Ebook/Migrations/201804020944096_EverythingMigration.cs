namespace Ebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EverythingMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ControlTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EDU_actions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        action = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Edu_Plan_Content",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        subject_id = c.String(),
                        total_hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EDU_plan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Spec_name = c.String(),
                        Begin_year = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cathedra = c.String(),
                        Position = c.String(),
                        GroupName = c.String(),
                        Status = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Group_name = c.String(),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subjects");
            DropTable("dbo.Status");
            DropTable("dbo.Lessons");
            DropTable("dbo.Groups");
            DropTable("dbo.People");
            DropTable("dbo.EDU_plan");
            DropTable("dbo.Edu_Plan_Content");
            DropTable("dbo.EDU_actions");
            DropTable("dbo.ControlTypes");
        }
    }
}
