namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingDB : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.TB_T_ProjectMember", "User_Id");
            CreateIndex("dbo.TB_M_Replies", "Reply_From");
            CreateIndex("dbo.TB_M_Ticket", "From_Userid");
            CreateIndex("dbo.TB_T_Tasks", "AssignBy");
            AddForeignKey("dbo.TB_T_ProjectMember", "User_Id", "dbo.TB_M_Employee", "Id", cascadeDelete: false);
            AddForeignKey("dbo.TB_M_Replies", "Reply_From", "dbo.TB_M_Employee", "Id", cascadeDelete: false);
            AddForeignKey("dbo.TB_M_Ticket", "From_Userid", "dbo.TB_M_Employee", "Id", cascadeDelete: false);
            AddForeignKey("dbo.TB_T_Tasks", "AssignBy", "dbo.TB_M_Employee", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_Tasks", "AssignBy", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_M_Ticket", "From_Userid", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_M_Replies", "Reply_From", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_T_ProjectMember", "User_Id", "dbo.TB_M_Employee");
            DropIndex("dbo.TB_T_Tasks", new[] { "AssignBy" });
            DropIndex("dbo.TB_M_Ticket", new[] { "From_Userid" });
            DropIndex("dbo.TB_M_Replies", new[] { "Reply_From" });
            DropIndex("dbo.TB_T_ProjectMember", new[] { "User_Id" });
        }
    }
}
