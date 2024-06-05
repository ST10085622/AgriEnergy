using AgriEnergy.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergy.Data
{
    public class AgriEnergyContext : DbContext
    {
        
        public AgriEnergyContext(DbContextOptions<AgriEnergyContext> options) :base(options)
        {
            
        }
        
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Farmer> Farmers { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
