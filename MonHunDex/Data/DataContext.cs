using Microsoft.EntityFrameworkCore;
using MonHunDex.Models;

namespace MonHunDex.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=monhundex;Trusted_Connection=true;TrustedServerCertificate=true;");
        }

        public DbSet<Monster> SuperHeroes => Set<Monster>();

        public DbSet<Move> Moves => Set<Move>();

        public DbSet<LocationType> LocationTypes => Set<LocationType>();
    }
}
