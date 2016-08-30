namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectTasksFix1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProjectTasks", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.ProjectTasks", "OutlineNumber", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProjectTasks", "OutlineLevel", c => c.Int());
            AlterColumn("dbo.ProjectTasks", "Start", c => c.DateTime());
            AlterColumn("dbo.ProjectTasks", "Finish", c => c.DateTime());
            AlterColumn("dbo.ProjectTasks", "ActualCost", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ProjectTasks", "Cost", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProjectTasks", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProjectTasks", "ActualCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProjectTasks", "Finish", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProjectTasks", "Start", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProjectTasks", "OutlineLevel", c => c.Int(nullable: false));
            AlterColumn("dbo.ProjectTasks", "OutlineNumber", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ProjectTasks", "Name", c => c.String());
        }
    }
}
