using Microsoft.EntityFrameworkCore;
using smartwallet1.web.Data.Entities;
using smartwallet1.web.Data.MappingConfiguration;

namespace smartwallet1.web.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
            {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Language>Languages { get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}


