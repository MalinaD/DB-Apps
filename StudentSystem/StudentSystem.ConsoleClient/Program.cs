namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Data.Migrations;
    using Data;
    using Models;
    using System.Collections.Generic;
    using System.Runtime.InteropServices.ComTypes;
    using System.Linq;
    //using System.Runtime.CompilerServices;

    using StudentSystem.Models;
    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;

    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext,Configuration>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext>());

            var studentSystemEntities = new StudentSystemDbContext();

            var newCourse = new Course
            {
                CourseName = "Java",
                CourseDescription = "Java course for beginners",
                Price = 600.0m,
                CourseStartDate = new DateTime(2015, 04, 01),
                CourseEndDate = new DateTime(2015, 06, 30)
            };

            newCourse.Resourse.Add(new Resourse
            {
                ResourseName = "Introduction to the Java programmer world",
                Link = "http://www.introprogramming.info/intro-java-book/",
                Type = ResourseType.Video
            });

            newCourse.Resourse.Add(new Resourse
            {
                ResourseName = "Primitive types and variables in Java",
                Link = "http://www.introprogramming.info/intro-java-book/",
                Type = ResourseType.Presentation
            });

            var newStudent = new Student
            {
                 FirstName = "Yordan",
                 LastName = "Stamatev"
            };

            newStudent.Homework.Add(new Homework
            {
                Content = "Hello World",
                ContentType = HomeworkContentType.AppWord,
                HomeworkDateTime = new DateTime(2015, 04, 10)
            });

            newStudent.Homework.Add(new Homework
            {
                Content = "A few Java programms with variables in mathematical assgnments",
                ContentType = HomeworkContentType.AppZip,
                HomeworkDateTime = new DateTime(2015, 04, 17)
            });

            newCourse.Student.Add(newStudent);
            studentSystemEntities.Courses.Add(newCourse);
            studentSystemEntities.SaveChanges();

            var students = studentSystemEntities.Students;

            foreach (var student in students)
            {
                Console.WriteLine(" Student: " + student.FullName);
                Console.Write(" Homewors: ");

                var currStudentHomeworks = student.Homework.ToList();
                foreach (var homework in currStudentHomeworks)
                {
                    Console.Write(" " + homework.Content + ", Content Type: " +
                    homework.ContentType.ToString() + ", Time for Homework: " +
                    homework.HomeworkDateTime.ToShortDateString());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

           // data.SaveChanges();

        }
    }
}
