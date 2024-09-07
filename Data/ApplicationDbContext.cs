using EducationAndCareerRecommendationsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EducationAndCareerRecommendationsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Definir DbSets para suas entidades, por exemplo:
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
namespace EducationAndCareerRecommendationsAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CareerGoal { get; set; }
    }
}
