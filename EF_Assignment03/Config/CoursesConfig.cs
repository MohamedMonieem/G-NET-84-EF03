using EF_Assignment03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment03.Config
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(a=>a.Title).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Description).HasMaxLength(50);
            builder.Property(a => a.Price).HasPrecision(10, 2);


            // Instructor - Course (1:M)
            builder.HasOne(a => a.Instructor)
                    .WithMany(a => a.Courses)
                    .HasForeignKey(a => a.InstructorId);


            // course - category (1:M)
            builder.HasOne(b => b.Category)
                   .WithMany(b => b.Courses)
                   .HasForeignKey(b => b.CategoryId);
                   




            //seed Data
            builder.HasData(
                new Course { Id = 500 ,Title = ".Net", Level  = CourseLevel.Beginner , Price = 7000 , Flag = true           , CategoryId = 1001 , InstructorId = 1 } ,
                new Course { Id = 501, Title = "MongoDb", Level = CourseLevel.Intermediate, Price = 7000, Flag = true       , CategoryId = 1000 , InstructorId = 2 } ,
                new Course { Id = 502, Title = "Docker", Level = CourseLevel.Advanced, Price = 10000, Flag = false          , CategoryId = 1005 , InstructorId = 1 } ,
                new Course { Id = 503, Title = "linuxSystemAdmin", Level = CourseLevel.Beginner, Price = 6000, Flag = false , CategoryId = 1004 , InstructorId = 2 } ,
                new Course { Id = 504, Title = "Angular", Level = CourseLevel.Beginner, Price = 7000, Flag = true           , CategoryId = 1003 , InstructorId = 3 } ,
                new Course { Id = 505, Title = "React", Level = CourseLevel.Beginner, Price = 7000, Flag = true             , CategoryId = 1004 , InstructorId = 3 }
                );

           
        }
    }
}
