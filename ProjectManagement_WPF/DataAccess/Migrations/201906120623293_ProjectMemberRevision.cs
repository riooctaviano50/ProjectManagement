namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectMemberRevision : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TB_T_ProjectMember", "Project_Id");
            AddForeignKey("dbo.TB_T_ProjectMember", "Project_Id", "dbo.TB_M_Projects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_ProjectMember", "Project_Id", "dbo.TB_M_Projects");
            DropIndex("dbo.TB_T_ProjectMember", new[] { "Project_Id" });
        }
    }
}
