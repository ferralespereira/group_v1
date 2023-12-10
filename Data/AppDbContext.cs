using Microsoft.EntityFrameworkCore;
using group_v1.Models;

namespace group_v1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your connection string.
            var connectionString = "server=localhost;user=root;password=root;database=group_v1";
            
            // Update your MySql version here "new Version(*, *, *)"
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}