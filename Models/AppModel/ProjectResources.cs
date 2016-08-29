using System.Collections.Generic;

namespace Models.AppModel
{
    public class ProjectResources
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public List<int> ResourceIds { get; set; }
    }
}