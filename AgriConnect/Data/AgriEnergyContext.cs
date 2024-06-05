using Microsoft.EntityFrameworkCore;

namespace AgriEnergy.Data
{
    public class AgriEnergyContext : DbContext
    {
        private readonly string _connectionString;

        public AgriEnergyContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Farmer> Farmers { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }



    }
}
