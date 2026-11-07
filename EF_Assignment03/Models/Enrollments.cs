using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment03.Models
{

    public enum Status { Active, Completed, Dropped }



    internal class Enrollment
    {
      
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public DateOnly EnrollmentDate { get; set; }
        public Decimal? Grade { get; set; }
        public Status Status { get; set; }
        public decimal ProgressPercentage { get; set; }




        //A student can enroll in many courses, and a course can have many students.
        // student - course (N:M)

        // student-Enroll (1-M)
        // student       Enroll
        //    1             M

        // Enroll-Course (1:M)
        // Enroll         Course   
        //    1              M


        // 1) student-Enroll (1-M)
        //   public int StudentId { get; set; }                  //FK already avialable
        public Student StudentEnroll { get; set; } = null!;        // nav pro



        // 2) Enroll-Course (1:M)
        // public int CourseId { get; set; }         // already available
        public Course Course { get; set; } = null!;


    }
}
