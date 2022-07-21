using DatabaseLayer.Models.Moves;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Services
{
    public class MovesService
    {
        public MovesService ()
        {
        }

        public async Task<bool> DoesKeyExistAsync(string key)
        {
            var result = await ReadAsync(key);

            return result != null;
        }

        public async Task<Move> ReadAsync(string key)
        {
            var ctx = new DWDataContext();

            var result =  await ctx.Moves.SingleOrDefaultAsync<Move>(x => x.Key == key);
            
            return result;

        }
        private async Task<bool> CreateAsync(Move m)
        {
            try
            {
                var ctx = new DWDataContext();

                ctx.Moves.Add(m);

                await ctx.SaveChangesAsync();
            }
            catch(System.Exception ex )
            {
                return false;
            }

            return true;
        }

        public async Task<bool> CreateAsync(string name, string key, string description, string? requires, string? replaces)
        {
            Move m_requires = null;
            Move m_replaces = null;

            if (requires != null)
            {
                m_requires = await ReadAsync(requires);
            }

            if ((requires != null) && (m_requires == null))
            {
                return false;
            }

            if (replaces != null)
            {
                m_replaces = await ReadAsync(replaces);
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

            return await CreateAsync(m);
        }


    }
}
