using EF_Assignment03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment03.Config
{
    internal class Instructor_Config : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Instructor> builder)
        {
        
            builder.HasKey(a => a.Id);       // pk
            builder.Property(b=>b.FullName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Bio).HasMaxLength(50);
            builder.Property(d => d.Email).HasMaxLength(50).IsRequired();

            builder.HasData(

                new Instructor { Id = 1, FullName = "Rana Hatem", Email = "rana@route.com", DateJoin = new DateOnly(2023, 1, 1) },
                new Instructor { Id = 2, FullName = "Ahmed Shaker", Email = "shaker@route.com", DateJoin = new DateOnly(2023, 1, 1) },
                new Instructor { Id = 3, FullName = "Amina", Email = "Amina@route.com", DateJoin = new DateOnly(2023, 1, 1) }

                );



        }
    }
}
