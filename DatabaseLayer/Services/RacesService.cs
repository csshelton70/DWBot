using DatabaseLayer.Models.Characters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Services
{
    public class RacesService
    {

        public async Task< List<Race>> GetListAsync()
        {
            var ctx = new DWDataContext();

            var result = await ctx.Races.Include(x => x.RaceNameSuggestions).ToListAsync<Race>();

            return result;
        }
    }
}
