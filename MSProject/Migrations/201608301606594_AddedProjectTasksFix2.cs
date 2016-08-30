namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectTasksFix2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProjectTasks", "OutlineNumber", c => c.String(maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProjectTasks", "OutlineNumber", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
