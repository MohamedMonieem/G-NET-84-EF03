using EF_Assignment03.Config;
using EF_Assignment03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment03.Db_Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Online Learning Platform;Trusted_Connection=true;TrustServerCertificate=true;");
        }


        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Enrollment>(new EnrollmentConfig());
            modelBuilder.ApplyConfiguration<Course>(new CourseConfig());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfig());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfig());
            modelBuilder.ApplyConfiguration<Instructor>(new Instructor_Config());
        }

    }
}
