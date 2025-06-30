using Microsoft.EntityFrameworkCore;

namespace APIcreation.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        public DbSet<District> Districts { get; set; }


    }
}
