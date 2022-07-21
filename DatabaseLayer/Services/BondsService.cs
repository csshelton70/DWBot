using DatabaseLayer.Models.Characters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Services
{
    public class BondsService
    {

        public async Task<List<Bond>> GetListAsync()
        {
            var ctx = new DWDataContext();

            var result = await ctx.Bonds.ToListAsync<Bond>();

            return result;
        }
    }
}
