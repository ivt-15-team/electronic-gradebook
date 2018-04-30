namespace Ebook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Edu_Plan_Content", "eduPlan_Id", c => c.Int());
            AlterColumn("dbo.EDU_plan", "Begin_year", c => c.Int(nullable: false));
            CreateIndex("dbo.Edu_Plan_Content", "eduPlan_Id");
            AddForeignKey("dbo.Edu_Plan_Content", "eduPlan_Id", "dbo.EDU_plan", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Edu_Plan_Content", "eduPlan_Id", "dbo.EDU_plan");
            DropIndex("dbo.Edu_Plan_Content", new[] { "eduPlan_Id" });
            AlterColumn("dbo.EDU_plan", "Begin_year", c => c.String());
            DropColumn("dbo.Edu_Plan_Content", "eduPlan_Id");
        }
    }
}
