namespace MSProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResourceAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Initials = c.String(maxLength: 4),
                        Start = c.DateTime(nullable: false),
                        Finish = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resources");
        }
    }
}
