using DatabaseLayer.Models.Moves;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class CharacterClassContext : DbContext
    {
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<Bond> Bonds { get; set; }

        public DbSet<Spell> Spells { get; set; }

        private string DbPath { get; }

        public CharacterClassContext()
        { //(DbContextOptions<MoveContext> options) : base(options) {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "DungeonWorld_CharacterClasses.db");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        
            base.OnModelCreating(modelBuilder);
        }


    }
}
