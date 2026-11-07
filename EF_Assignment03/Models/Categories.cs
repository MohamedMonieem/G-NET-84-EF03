using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment03.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } 

        public int? ParentCategoryId { get; set; }


        // category - subcategory (1:M) self
        //  public int? ParentCategoryId { get; set; }   // available already 

        public Category? ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; } = new HashSet<Category>();



        // course - category
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();    // nav pro


    }
}
