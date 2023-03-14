
using Microsoft.EntityFrameworkCore;
using sample_api.Models;

namespace sample_api.Data
{
    public class PersonContext : DbContext
    {
        
        public DbSet<person> persons {get; set;}
        public DbSet<unitList> unitLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=123456;Database=mockData");
        }
    }
}