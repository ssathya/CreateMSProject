using System;
using System.Collections.Generic;

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
        public string Name { get; set; }
        public decimal OutlineNumber { get; set; }
        public int OutlineLevel { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public List<int> Sucessors { get; set; }
        public List<int> Predecessors { get; set; }
        public decimal ActualCost { get; set; }
        public decimal Cost { get; set; }
    }
}