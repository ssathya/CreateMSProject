namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        Name = c.String(),
                        OutlineNumber = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OutlineLevel = c.Int(nullable: false),
                        Start = c.DateTime(nullable: false),
                        Finish = c.DateTime(nullable: false),
                        ActualCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectTasks", "ProjectId", "dbo.Projects");
            DropIndex("dbo.ProjectTasks", new[] { "ProjectId" });
            DropTable("dbo.ProjectTasks");
        }
    }
}
