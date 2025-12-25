using Microsoft.EntityFrameworkCore;

namespace P17_EntityFramework2.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;user=root;password=root;database=dotnet",
                ServerVersion.Parse("8.0.42-mysql")
            );
        }
    }
}
