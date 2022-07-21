using DatabaseLayer.Models.Characters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Services
{
    public class CharacterClassesService
    {

        public async Task<List<CharacterClass>> GetListAsync()
        {
            var ctx = new DWDataContext();

            var result = await ctx.CharacterClasses.Include(x => x.Bonds).Include(x => x.Spells).ToListAsync<CharacterClass>();

            return result;
        }
    }
}
