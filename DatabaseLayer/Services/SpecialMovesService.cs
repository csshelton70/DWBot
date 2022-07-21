using DatabaseLayer.Models.Moves;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Services
{
    public  class SpecialMovesService
    {

        public async Task<bool> CreateIfMissingAsync(Move m)
        {
            var special_move = await FindByIdAsync(m.Id);

            if (special_move == null)
            {
                return await CreateAsync(m);
            }
            return false;
        }

        public async Task<bool> CreateAsync(Move m)
        {

            try
            {
                SpecialMove bm = new SpecialMove()
                {
                    move = m
                };
                
                var ctx = new DWDataContext();

                await ctx.SpecialMoves.AddAsync(bm);
                
                await ctx.SaveChangesAsync();

            }
            catch (System.Exception ex)
            {
                var r = ex;
                return false;
            }

            return true;
        }

        public async Task<List<SpecialMove>> GetListAsync()
        {
            var ctx = new DWDataContext();

            var result = await ctx.SpecialMoves.ToListAsync();
            
            return result;
        }

        public async Task<SpecialMove> FindByIdAsync(int id)
        {
            var ctx = new DWDataContext();

            var result = await ctx.SpecialMoves.FirstOrDefaultAsync<SpecialMove>(x => x.Id == id);

            return result;
        }


    }
}
