using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment03.Models
{
    public enum CourseLevel { Beginner, Intermediate , Advanced }



    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public Decimal Price { get; set; }
        public CourseLevel Level { get; set; } 
        public bool Flag { get; set; }
        public DateOnly? PublishedDate { get; set; }


        // Instructor - Course (1:M)
        public int InstructorId { get; set; }         // fk 
        public Instructor Instructor { get; set; } = null!;   // Nav Pro



        // course - category (1:M)
        public int CategoryId { get; set; }      //FK
        public Category Category { get; set; } = null!;



        // 2) Enroll-Course (1:M)
        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();


    }
}
