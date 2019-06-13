namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingReplyandTicket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_T_ProjectMember",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Project_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_Replies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        Reply_From = c.Int(nullable: false),
                        Ticket_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Ticket", t => t.Ticket_Id, cascadeDelete: true)
                .Index(t => t.Ticket_Id);
            
            CreateTable(
                "dbo.TB_M_Ticket",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From_Userid = c.Int(nullable: false),
                        Message = c.String(),
                        Project_Id = c.Int(nullable: false),
                        Status_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_T_ProjectMember", t => t.Project_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_Status", t => t.Status_Id, cascadeDelete: true)
                .Index(t => t.Project_Id)
                .Index(t => t.Status_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Replies", "Ticket_Id", "dbo.TB_M_Ticket");
            DropForeignKey("dbo.TB_M_Ticket", "Status_Id", "dbo.TB_M_Status");
            DropForeignKey("dbo.TB_M_Ticket", "Project_Id", "dbo.TB_T_ProjectMember");
            DropIndex("dbo.TB_M_Ticket", new[] { "Status_Id" });
            DropIndex("dbo.TB_M_Ticket", new[] { "Project_Id" });
            DropIndex("dbo.TB_M_Replies", new[] { "Ticket_Id" });
            DropTable("dbo.TB_M_Ticket");
            DropTable("dbo.TB_M_Replies");
            DropTable("dbo.TB_T_ProjectMember");
        }
    }
}
