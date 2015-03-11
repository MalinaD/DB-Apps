
namespace StudentSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Runtime.Remoting;
    using StudentSystem.Models;
    using System.Linq;

    public interface IStudentSystemDbContext
    {
        IDbSet<Student> Students { get; set; }
        IDbSet<Homework> Homeworks { get; set; }
        IDbSet<Course> Courses { get; set; }
        IDbSet<Resourse> Resourses { get; set; }

        int SaveChanges();

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        IDbSet<T> Set<T>() where T : class;


    }
}
