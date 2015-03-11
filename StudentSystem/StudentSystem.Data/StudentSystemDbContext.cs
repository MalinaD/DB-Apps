namespace StudentSystem.Data
{
    using System.Data.Entity;
    using StudentSystem.Models;
    

    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
            : base("StudentSystem")
        {

        }

        public IDbSet<Course> Courses { get; set; }
        public IDbSet<Resourse> Resources { get; set; }
        public IDbSet<Homework> Homeworks { get; set; }
        public IDbSet<Student> Students { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(s => s.Birthday)
            .HasColumnType("datetimeSecond");
            base.OnModelCreating(modelBuilder);
        }

    }
}
