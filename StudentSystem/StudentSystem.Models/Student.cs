
namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        //id, name, phone number, registration date, birthday
        private ICollection<Course> course;
        private ICollection<Homework> homework;

        public Student()
        {
            this.course = new HashSet<Course>();
            this.homework = new List<Homework>();

            this.RegistrationDate = DateTime.Now;
        }

        public int Id { get; set; }

         [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }

        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<Course> Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public virtual ICollection<Homework> Homework
        {
            get { return this.homework; }
            set { this.homework = value; }
        }

    }
}
