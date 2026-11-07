using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment03.Models
{
    internal class Instructor 
    {

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string? Bio { get; set; }
        public string Email { get; set; } = null!;
        public DateOnly DateJoin { get; set; }



        // Instructor - Course (1:M)
        public ICollection<Course> Courses { get; set; } = new HashSet<Course> (); // nav pro

    }
}
