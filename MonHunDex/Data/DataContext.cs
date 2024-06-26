﻿global using Microsoft.EntityFrameworkCore;
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

            modelBuilder.Entity<MonsterAilment>().HasKey(ma => new { ma.AilmentId, ma.MonsterId });
            modelBuilder.Entity<MonsterAilment>().HasOne(ma => ma.Monster).WithMany(m => m.MonsterAilments).HasForeignKey(ma => ma.MonsterId);
            modelBuilder.Entity<MonsterAilment>().HasOne(ma => ma.Ailment).WithMany(a => a.MonsterAilments).HasForeignKey(ma => ma.AilmentId);

            modelBuilder.Entity<MonsterLocation>().HasKey(ml => new { ml.LocationId, ml.MonsterId });
            modelBuilder.Entity<MonsterLocation>().HasOne(ml => ml.Monster).WithMany(m => m.MonsterLocations).HasForeignKey(ml => ml.MonsterId);
            modelBuilder.Entity<MonsterLocation>().HasOne(ml => ml.Location).WithMany(l => l.MonsterLocations).HasForeignKey(ml => ml.LocationId);

            modelBuilder.Entity<MonsterMove>().HasKey(mm => new { mm.MoveId, mm.MonsterId });
            modelBuilder.Entity<MonsterMove>().HasOne(mm => mm.Monster).WithMany(m => m.MonsterMoves).HasForeignKey(mm => mm.MonsterId);
            modelBuilder.Entity<MonsterMove>().HasOne(mm => mm.Move).WithMany(m => m.MonsterMoves).HasForeignKey(mm => mm.MoveId);

            modelBuilder.Entity<MonsterWeakness>().HasKey(mw => new { mw.MonsterId, mw.ElementId });
            modelBuilder.Entity<MonsterWeakness>().HasOne(mw => mw.Monster).WithMany(m => m.MonsterWeaknesses).HasForeignKey(mw => mw.MonsterId);
            modelBuilder.Entity<MonsterWeakness>().HasOne(mw => mw.Element).WithMany(e => e.MonsterWeaknesses).HasForeignKey(mw => mw.ElementId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=monhundex;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Monster> Monsters => Set<Monster>();
        public DbSet<Move> Moves => Set<Move>();
        public DbSet<LocationType> LocationTypes => Set<LocationType>();
        public DbSet<Location> Locations => Set<Location>();
        public DbSet<MonsterLocation> MonsterLocations => Set<MonsterLocation>();
        public DbSet<MonsterMove> MonsterMoves => Set<MonsterMove>();
        public DbSet<MonsterTitle> MonsterTitles => Set<MonsterTitle>();
        public DbSet<Element> Elements => Set<Element>();
        public DbSet<MonsterElement> MonsterElements => Set<MonsterElement>();
        public DbSet<Ailment> Ailments => Set<Ailment>();
        public DbSet<MonsterAilment> MonsterAilments => Set<MonsterAilment>();
        public DbSet<MonsterClass> MonsterClasses => Set<MonsterClass>();
        public DbSet<Behavior> Behaviors => Set<Behavior>();
        public DbSet<MonsterWeakness> MonsterWeaknesses => Set<MonsterWeakness>();
    }
}
