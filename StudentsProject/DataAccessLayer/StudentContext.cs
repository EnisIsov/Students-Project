using StudentsProject.Models;
using System.Data.Entity;

namespace StudentsProject.DataAccessLayer
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentConnString")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {



            base.OnModelCreating(modelBuilder);
        }
    }
}