namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelProjectTask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectStart = c.DateTime(nullable: false),
                        ProjectDeadline = c.DateTime(nullable: false),
                        ProjectDetails = c.String(),
                        Status_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Status", t => t.Status_Id, cascadeDelete: true)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.TB_M_Status",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Projects", "Status_Id", "dbo.TB_M_Status");
            DropIndex("dbo.TB_M_Projects", new[] { "Status_Id" });
            DropTable("dbo.TB_M_Status");
            DropTable("dbo.TB_M_Projects");
        }
    }
}
