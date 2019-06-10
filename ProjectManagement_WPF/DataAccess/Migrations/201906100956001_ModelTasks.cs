namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelTasks : DbMigration
    {
        public override void Up()
        {
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
                .ForeignKey("dbo.TB_M_Status", t => t.Status_Id)
                .Index(t => t.Status_Id)
                .Index(t => t.Project_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_Tasks", "Status_Id", "dbo.TB_M_Status");
            DropForeignKey("dbo.TB_T_Tasks", "Project_Id", "dbo.TB_M_Projects");
            DropIndex("dbo.TB_T_Tasks", new[] { "Project_Id" });
            DropIndex("dbo.TB_T_Tasks", new[] { "Status_Id" });
            DropTable("dbo.TB_T_Tasks");
        }
    }
}
