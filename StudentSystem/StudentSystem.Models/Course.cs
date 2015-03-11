
namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Course
    {
        //id, name, description, start date, end date, price
        //•	Courses can have many students
        //•	Courses can have many resources


        private ICollection<Resourse> resourse;
        private ICollection<Student> student;

        public Course()
        {
            this.student = new HashSet<Student>();
            this.resourse = new HashSet<Resourse>();
        }

        public int Id { get; set; }

        [Required]
        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        [Required]
        public DateTime CourseStartDate { get; set; }

        [Required]
        public DateTime CourseEndDate { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Student> Student
        {
            get { return this.student; }
            set { this.student = value; }
        }


        public virtual ICollection<Resourse> Resourse
        {
            get { return this.resourse; }
            set { this.resourse = value; }
        }

    }
}
