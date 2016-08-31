namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectTasksFix3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectTasks", "Duration", c => c.String(maxLength: 8));
            DropColumn("dbo.ProjectTasks", "Start");
            DropColumn("dbo.ProjectTasks", "Finish");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectTasks", "Finish", c => c.DateTime());
            AddColumn("dbo.ProjectTasks", "Start", c => c.DateTime());
            DropColumn("dbo.ProjectTasks", "Duration");
        }
    }
}
