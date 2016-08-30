using System.Collections.Generic;

namespace Models.AppModel
{
    public class ProjectResources
    {
        public ProjectResources()
        {
        }

        public int Id { get; set; }
        public int ProjectTaskId { get; set; }
        public virtual ProjectTask Task { get; set; }
        public int ResourceId { get; set; }
        public virtual Resource Resource { get; set; }
    }
}