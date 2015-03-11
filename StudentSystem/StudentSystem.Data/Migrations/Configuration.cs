namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using StudentSystem.Models;
    using StudentSystem.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var javaCourse = new Course
            {
                CourseName = "Java",
                CourseDescription = "Java for beginners",
                Price = 200.0m,
                CourseStartDate = new DateTime(2015, 02, 02),
                CourseEndDate = new DateTime(2015, 03, 30)
            };

            var firstStudent = new Student()
            {
                FirstName = "Nataliya",
                LastName = "Ivanova",
                Birthday = new DateTime(1988, 01, 01),
                PhoneNumber = "0888888888"
            };

            var homeworkFirst = new Homework()
            {
                Content = "Still waiting",
                ContentType = HomeworkContentType.AppZip,
                Course = javaCourse,
                Student = firstStudent,
                HomeworkDateTime = new DateTime(2015, 03, 30)
            };

            var phpCourse = new Course
            {
                CourseName = "PHP",
                CourseDescription = "Will be available soon",
                Price = 200.0m,
                CourseStartDate = new DateTime(2015, 02, 02),
                CourseEndDate = new DateTime(2015, 03, 30)
            };

            var secondStudent = new Student
            {
                FirstName = "Natanail",
                LastName = "Petrov",
                Birthday = new DateTime(1987, 01, 01),
                PhoneNumber = "0878888888"
            };

            var homeworkSecond = new Homework()
            {
                Content = "Nothing",
                ContentType = HomeworkContentType.AppRar,
                Course = phpCourse,
                Student = secondStudent,
                HomeworkDateTime = new DateTime(2015, 03, 30)
            };

            context.Homeworks.Add(homeworkFirst);
            context.Homeworks.Add(homeworkSecond);
            context.SaveChanges();
        }
    }
}
