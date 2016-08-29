namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectDataTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Projects", "Manager", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Manager", c => c.String());
            AlterColumn("dbo.Projects", "Title", c => c.String());
        }
    }
}
