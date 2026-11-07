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
    internal class EnrollmentConfig : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {

            builder.HasKey(e => new { e.StudentId, e.CourseId });  // comp key

            builder.Property(e => e.Grade)
             .HasPrecision(5, 2);

            builder.Property(e => e.ProgressPercentage)
                   .HasPrecision(5, 2);


            // student - Enroll(1 - M)
            builder.HasOne(e => e.StudentEnroll)
                   .WithMany(e => e.Enrollments)
                   .HasForeignKey(e => e.StudentId);

            // Enrollment - Course (M:1)
            builder.HasOne(e => e.Course)
                   .WithMany(c => c.Enrollments)
                   .HasForeignKey(e => e.CourseId);

        }
    }

}
