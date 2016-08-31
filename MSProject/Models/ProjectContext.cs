using Models.AppModel;
using System.Data.Entity;

namespace MSProject.Models
{
    public class ProjectContext : DbContext, IProjectContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        //
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public ProjectContext() : base("name=ProjectContext")
        {
        }

        public DbSet<ProjectResources> ProjectResources { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
    }
}