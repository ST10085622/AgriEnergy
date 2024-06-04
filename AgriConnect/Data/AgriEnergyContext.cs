using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace AgriEnergy.Data
{
    public class AgriEnergyContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }

        public DbSet<Farmers> Farmers { get; set; }

        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=labVMH8OX\SQLEXPRESS;Database=agrienergy;Username=labVMH8OX\lab_services_student;Password=null;Trusted_Connection=True;");
        }



    }
}
