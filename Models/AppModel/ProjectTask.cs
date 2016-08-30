using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models.AppModel
{
    public class ProjectTask
    {
        public ProjectTask()
        {
            Sucessors = new List<int>();
            Predecessors = new List<int>();
        }

        public int Id { get; set; }

        [Required, Display(Name = "Project Name")]
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        [Required(ErrorMessage = "Task needs a name"),
            StringLength(30),
            Display(Name = "Task name"),
         MinLength(3, ErrorMessage = "Task name needs to be at least 3 char. long")]
        public string Name { get; set; }

        [Display(Name = "Parent/Child number"), StringLength(8)]
        public string OutlineNumber { get; set; }

        [Display(Name = "Child level")]
        public int? OutlineLevel { get; set; }

        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public List<int> Sucessors { get; set; }
        public List<int> Predecessors { get; set; }

        [Display(Name = "Actual cost (optional)")]
        public decimal? ActualCost { get; set; }

        [Display(Name = "Item cost (optional)")]
        public decimal? Cost { get; set; }
    }
}