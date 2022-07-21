using DatabaseLayer.Models.Moves;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Services
{
    public  class BasicMovesService
    {
        public async Task<bool> CreateIfMissingAsync(Move m)
        {
            var basic_move = await FindByIdAsync(m.Id);

            if (basic_move == null)
            {
                return await this.CreateAsync(m);
            }
            
            return false;
        }

        public async Task<bool> CreateAsync(Move m)
        {
            try
            {
                BasicMove bm = new BasicMove()
                {
                    move = m
                };

                var ctx = new DWDataContext();

                await ctx.BasicMoves.AddAsync(bm);
                
                await ctx.SaveChangesAsync();

            }
            catch (System.Exception ex)
            {
                var r = ex;
                return false;
            }

            return true;
        }

        public async Task<List<BasicMove>> GetListAsync()
        {
            var ctx = new DWDataContext();

            var result = await ctx.BasicMoves.ToListAsync();

            return result;
        }

        public async Task<BasicMove> FindByIdAsync(int id)
        {
            var ctx = new DWDataContext();

            var result = await ctx.BasicMoves.FirstOrDefaultAsync<BasicMove>(x => x.Id == id);

            return result;
        }


    }
}
