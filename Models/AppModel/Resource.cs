using System;
using System.ComponentModel.DataAnnotations;

namespace Models.AppModel
{
    public class Resource
    {
        public int Id { get; set; }

        [Required, StringLength(30), Display(Name = "Resource Name")]
        public string Name { get; set; }

        [StringLength(4), Display(Name = "Resource Initials")]
        public string Initials { get; set; }

        [DataType(DataType.Date)]
        public DateTime Start { get; set; }

        [DataType(DataType.Date)]
        public DateTime Finish { get; set; }
    }
}