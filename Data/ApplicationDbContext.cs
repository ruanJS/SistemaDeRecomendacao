using Microsoft.EntityFrameworkCore;
using EducationAndCareerRecommendationsAPI.Models;

namespace EducationAndCareerRecommendationsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
