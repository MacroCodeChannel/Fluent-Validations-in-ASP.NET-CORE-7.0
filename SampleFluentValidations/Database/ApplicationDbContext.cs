using Microsoft.EntityFrameworkCore;
using SampleFluentValidations.Models;

namespace SampleFluentValidations.Database
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students {  get; set; }
    }
}
