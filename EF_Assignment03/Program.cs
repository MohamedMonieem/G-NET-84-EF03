using EF_Assignment03.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace EF_Assignment03
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AppDbContext dbContext = new AppDbContext();

            // seeding data 
            if (!await dbContext.Students.AnyAsync())

            {
                dbContext.Students.AddRange(
                    new Models.Student { FullName = "Mohamed", Email = "mohamed.moniem.eng@gmail.com" , DOB = new DateOnly(1993, 4, 10) },
                    new Models.Student { FullName = "Ahmed", Email = "Ahmed.moniem.eng@gmail.com", DOB = new DateOnly(1993, 4, 10) },
                    new Models.Student { FullName = "Ali", Email = "Ali.moniem.eng@gmail.com", DOB = new DateOnly(1993, 4, 10) },
                    new Models.Student { FullName = "3bas", Email = "3bas.moniem.eng@gmail.com", DOB = new DateOnly(1993, 4, 10) },
                    new Models.Student { FullName = "Sayed", Email = "Sayes.moniem.eng@gmail.com", DOB = new DateOnly(1993, 4, 10) }
                    );

                  await dbContext.SaveChangesAsync();
            }






        }
    }
}
