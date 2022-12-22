using Microsoft.EntityFrameworkCore;
using MonHunDex.Models;

namespace MonHunDex.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Monster> SuperHeroes => Set<Monster>();
    }
}
