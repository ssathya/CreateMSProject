using System.Data.Entity;
using Models.AppModel;

namespace MSProject.Models
{
    public interface IProjectContext
    {
        DbSet<Project> Projects { get; set; }
        DbSet<Resource> Resources { get; set; }
        DbSet<ProjectTask> ProjectTasks { get; set; }
    }
}