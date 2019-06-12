namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllModelComplete : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        User_Id = c.Int(nullable: false),
                        Rules_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Rule", t => t.Rules_Id, cascadeDelete: true)
                .Index(t => t.Rules_Id);
            
            CreateTable(
                "dbo.TB_M_Rule",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        Priority = c.String(),
                        AssignBy = c.Int(nullable: false),
                        AssignTo = c.Int(nullable: false),
                        Status_Id = c.Int(nullable: false),
                        Project_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Projects", t => t.Project_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_Status", t => t.Status_Id, cascadeDelete: false)
                .Index(t => t.Status_Id)
                .Index(t => t.Project_Id);
            
            AddColumn("dbo.TB_T_ProjectMember", "Rules_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TB_T_ProjectMember", "Rules_Id");
            AddForeignKey("dbo.TB_T_ProjectMember", "Rules_Id", "dbo.TB_M_Rule", "Id", cascadeDelete: true);
            DropColumn("dbo.TB_T_ProjectMember", "Role_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_T_ProjectMember", "Role_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.TB_T_Tasks", "Status_Id", "dbo.TB_M_Status");
            DropForeignKey("dbo.TB_T_Tasks", "Project_Id", "dbo.TB_M_Projects");
            DropForeignKey("dbo.TB_T_ProjectMember", "Rules_Id", "dbo.TB_M_Rule");
            DropForeignKey("dbo.TB_M_Employee", "Rules_Id", "dbo.TB_M_Rule");
            DropIndex("dbo.TB_T_Tasks", new[] { "Project_Id" });
            DropIndex("dbo.TB_T_Tasks", new[] { "Status_Id" });
            DropIndex("dbo.TB_T_ProjectMember", new[] { "Rules_Id" });
            DropIndex("dbo.TB_M_Employee", new[] { "Rules_Id" });
            DropColumn("dbo.TB_T_ProjectMember", "Rules_Id");
            DropTable("dbo.TB_T_Tasks");
            DropTable("dbo.TB_M_Rule");
            DropTable("dbo.TB_M_Employee");
        }
    }
}
