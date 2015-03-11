
namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.CompilerServices;

    public class Resourse
    {
        //id, name, type of resource (video / presentation / document / other), link
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string ResourseName { get; set; }

        [Required]
        public ResourseType Type { get; set; }

        [Required]
        public string Link { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
