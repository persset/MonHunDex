using Microsoft.EntityFrameworkCore;
using MonHunDex.Models;

namespace MonHunDex.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonsterElement>().HasKey(me => new {me.ElementId, me.MonsterId});
            modelBuilder.Entity<MonsterElement>().HasOne(me => me.Monster).WithMany(m => m.MonsterElements).HasForeignKey(me => me.MonsterId);
            modelBuilder.Entity<MonsterElement>().HasOne(me => me.Element).WithMany(e => e.MonsterElements).HasForeignKey(me => me.ElementId);
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=monhundex;Trusted_Connection=true;TrustedServerCertificate=true;");
        }

        public DbSet<Monster> SuperHeroes => Set<Monster>();
        public DbSet<Move> Moves => Set<Move>();
        public DbSet<LocationType> LocationTypes => Set<LocationType>();
        public DbSet<Location> Locations => Set<Location>();
        public DbSet<MonsterLocation> MonsterLocations => Set<MonsterLocation>();
        public DbSet<MonsterMove> MonsterMoves => Set<MonsterMove>();
        public DbSet<MonsterTitle> MonsterTitles => Set<MonsterTitle>();
        public DbSet<Element> Elements => Set<Element>();
        public DbSet<MonsterElement> MonsterElements => Set<MonsterElement>();
        public DbSet<Ailment> Ailments => Set<Ailment>();
    }
}
