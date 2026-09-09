using Microsoft.EntityFrameworkCore;

namespace student_system.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
