using DatabaseLayer.Models.Characters;
using DatabaseLayer.Models.Moves;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class DWDataContext : DbContext
    {
        public DbSet<Move> Moves { get; set; }
        public DbSet<BasicMove> BasicMoves { get; set; }
        public DbSet<DungeonMove> DungeonMoves { get; set; }
        public DbSet<GMMove> GMMoves { get; set; }
        public DbSet<SpecialMove> SpecialMoves { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Bond> Bonds { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceNameSuggestion> RaceNameSuggestions { get; set; }

        private string DbPath { get; }

        public DWDataContext()
        { 
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "DungeonWorld_Static.db");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Move>().Property(m => m.Requires).IsRequired(false);

            modelBuilder.Entity<Move>().Property(m => m.Replaces).IsRequired(false);

            modelBuilder.Entity<CharacterClass>()
               .HasMany(c => c.Bonds)
               .WithOne(e => e.CharacterClass);

            modelBuilder.Entity<Race>()
                .HasMany(c => c.RaceNameSuggestions)
                .WithOne(r => r.Race);


            base.OnModelCreating(modelBuilder);
        }
    }
}
