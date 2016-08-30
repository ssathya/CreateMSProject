namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectTasksResources : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectResources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectTaskId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProjectTasks", t => t.ProjectTaskId, cascadeDelete: true)
                .Index(t => t.ProjectTaskId);
            
            AddColumn("dbo.Resources", "ProjectResources_Id", c => c.Int());
            CreateIndex("dbo.Resources", "ProjectResources_Id");
            AddForeignKey("dbo.Resources", "ProjectResources_Id", "dbo.ProjectResources", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectResources", "ProjectTaskId", "dbo.ProjectTasks");
            DropForeignKey("dbo.Resources", "ProjectResources_Id", "dbo.ProjectResources");
            DropIndex("dbo.Resources", new[] { "ProjectResources_Id" });
            DropIndex("dbo.ProjectResources", new[] { "ProjectTaskId" });
            DropColumn("dbo.Resources", "ProjectResources_Id");
            DropTable("dbo.ProjectResources");
        }
    }
}
