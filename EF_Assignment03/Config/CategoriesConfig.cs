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
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a=>a.Id);
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(50);


            // Category - subcat (1:M) self
            builder.HasOne(c => c.ParentCategory)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(c => c.ParentCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);


            // seed data
            builder.HasData(

                new Category { Id = 1, Name = "Programming" , ParentCategoryId = null } , 

                new Category { Id = 100, Name = "BackEnd", Description = "Backend course", ParentCategoryId = 1 },
                 new Category { Id = 101, Name = "FrontEnd", ParentCategoryId = 1 },
                  new Category { Id = 102, Name = "DevOps", ParentCategoryId = 1 },
                   new Category { Id = 103, Name = "MobileDevelop", ParentCategoryId = 1 },
                    new Category { Id = 104, Name = "SystemAdmin", ParentCategoryId = 1 } ,

                    new Category { Id = 1000 , Name="MongoDb", ParentCategoryId=100},
                    new Category { Id = 1001, Name = ".net", ParentCategoryId =100},
                    new Category { Id = 1002, Name = "PHP", ParentCategoryId = 100 },
                    new Category { Id = 1003, Name = "Angular", ParentCategoryId = 101 },
                    new Category { Id = 1004, Name = "React", ParentCategoryId = 101 },
                    new Category { Id = 1005, Name = "Docker", ParentCategoryId = 102 },
                    new Category { Id = 1006, Name = "CKA", ParentCategoryId = 102 },
                    new Category { Id = 1007, Name = "CKAD", ParentCategoryId = 102 }

                );





        }
    }
}
