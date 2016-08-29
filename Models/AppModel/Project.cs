using System;
using System.ComponentModel.DataAnnotations;

namespace Models.AppModel
{
    public class Project
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; }

        [Required, StringLength(30)]
        public string Manager { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime FinishDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime DefaultStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime DefaultEndTime { get; set; }
    }
}