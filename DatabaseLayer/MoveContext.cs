using DatabaseLayer.Models.Moves;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class MoveContext : DbContext
    {
        public DbSet<Move> Moves { get; set; }
        public DbSet<BasicMove> BasicMoves { get; set; }

        public DbSet<DungeonMove> DungeonMoves { get; set; }

        public DbSet<GMMove> GMMoves { get; set; }
        public DbSet<SpecialMove> SpecialMoves { get; set; }

        private string DbPath { get; }

        public MoveContext()
        { //(DbContextOptions<MoveContext> options) : base(options) {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "DungeonWorld_Moves.db");
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
        
            base.OnModelCreating(modelBuilder);
        }

        #region Moves

        public async Task<bool> Moves_DoesKeyExist(string key)
        {
            var result = await this.Moves_Read(key);
            return result != null;
        }

        public async Task<Move> Moves_Read(string key)
        {
            var x = await this.Moves.SingleOrDefaultAsync<Move>(x => x.Key == key);
            return x;

            //  return (await ctx.Moves.Where(x => x.Key == key).FirstOrDefaultAsync());

        }
        public async Task<bool> Moves_Create(string name, string key, string description, string? requires, string? replaces)
        {
            Move m_requires = null;
            Move m_replaces = null;


            if (requires != null)
            {
                m_requires = await Moves_Read(requires);
            }

            if ((requires != null) && (m_requires == null))
            {
                return false;
            }

            if (replaces != null)
            {
                m_replaces = await Moves_Read(replaces);
            }

            if ((replaces != null) && (m_replaces == null))
            {
                return false;
            }



            Move m = new Move()
            {
                Name = name,
                Description = description,
                Key = key,
                Requires = m_requires == null ? null : m_requires.Id,
                Replaces = m_replaces == null ? null : m_replaces.Id
            };

            this.Moves.Add(m);
            await this.SaveChangesAsync();
            return true;
        }


        #endregion

        #region GMMoves

        #endregion

        #region DungeonMoves

        #endregion

        #region BasicMoves

        public async Task<bool> BasicMoves_CreateIfMissing(Move m)
        {
            var basic_move = await Basic_Moves_FindByMoveId(m.Id);
            if ( basic_move == null )
            {
                return await this.BasicMoves_Create(m);
            }
            return false;
        }

        public async Task<bool> BasicMoves_Create(Move m)
        {
            try
            {
                BasicMove bm = new BasicMove()
                {
                    move = m
                };

                await this.BasicMoves.AddAsync(bm);
                await this.SaveChangesAsync();
                
            }
            catch (System.Exception ex)
            {
                var r = ex;
                return false;
            }
            return true;
        }

        public List<BasicMove> BasicMoves_GetList()
        {
            var result = this.BasicMoves.ToList();
            return result;
        }

        public async Task<BasicMove> Basic_Moves_FindByMoveId(int id)
        {
            var result = await this.BasicMoves.FirstOrDefaultAsync<BasicMove>(x => x.Id == id);
            return result;
        }

        #endregion

        #region SpecialMoves
        public async Task<bool> SpecialMoves_CreateIfMissing(Move m)
        {
            var special_move = await SpecialMoves_FindByMoveId(m.Id);
            if ( special_move == null )
            {
                return await this.SpecialMoves_Create(m);
            }
            return false;
        }

        public async Task<bool> SpecialMoves_Create(Move m)
        {
            try
            {
                SpecialMove bm = new SpecialMove()
                {
                    move = m
                };

                await SpecialMoves.AddAsync(bm);
                await SaveChangesAsync();
                
            }
            catch (System.Exception ex)
            {
                var r = ex;
                return false;
            }
            return true;
        }

        public List<SpecialMove> SpecialMoves_GetList()
        {
            var result = this.SpecialMoves.ToList();
            return result;
        }

        public async Task<SpecialMove> SpecialMoves_FindByMoveId(int id)
        {
            var result = await SpecialMoves.FirstOrDefaultAsync<SpecialMove>(x => x.Id == id);
            return result;
        }


        #endregion


    }
}
