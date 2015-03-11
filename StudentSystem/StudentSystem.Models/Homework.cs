
namespace StudentSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Homework
    {
        //id, content, content-type (e.g. application/pdf or application/zip), date and time
       //•	One course can have many homework submissions
        //•	Homework submissions have a student

        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public HomeworkContentType ContentType { get; set; }

        [Required]
        public DateTime HomeworkDateTime { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
