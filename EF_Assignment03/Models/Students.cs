using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_Assignment03.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;
        public DateOnly  DOB { get; set; }


        // 1)  student-Enroll (1-M)
        public ICollection<Enrollment> Enrollments { get; set; } = new HashSet<Enrollment>();





    }
}
