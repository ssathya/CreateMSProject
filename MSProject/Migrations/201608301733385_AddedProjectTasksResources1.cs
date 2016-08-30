namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectTasksResources1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resources", "ProjectResources_Id", "dbo.ProjectResources");
            DropIndex("dbo.Resources", new[] { "ProjectResources_Id" });
            AddColumn("dbo.ProjectResources", "ResourceId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProjectResources", "ResourceId");
            AddForeignKey("dbo.ProjectResources", "ResourceId", "dbo.Resources", "Id", cascadeDelete: true);
            DropColumn("dbo.Resources", "ProjectResources_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "ProjectResources_Id", c => c.Int());
            DropForeignKey("dbo.ProjectResources", "ResourceId", "dbo.Resources");
            DropIndex("dbo.ProjectResources", new[] { "ResourceId" });
            DropColumn("dbo.ProjectResources", "ResourceId");
            CreateIndex("dbo.Resources", "ProjectResources_Id");
            AddForeignKey("dbo.Resources", "ProjectResources_Id", "dbo.ProjectResources", "Id");
        }
    }
}
