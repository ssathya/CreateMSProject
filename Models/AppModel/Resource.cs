using System;
using System.Collections.Generic;

namespace Models.AppModel
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }

    public class ProjectResources
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public List<int> ResourceIds { get; set; }
    }
}