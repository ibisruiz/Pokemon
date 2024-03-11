using Microsoft.EntityFrameworkCore;
using PokePoke.Core.Application.Interfaces.Repositories;
using PokePoke.Core.Domain.Entities;
using PokePoke.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Infrastructure.Persistence.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly ApplicationContext context;

        public PokemonRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Pokemonn pokemon)
        {
            await context.Pokemonns.AddAsync(pokemon);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pokemonn pokemon)
        {
            context.Entry(pokemon).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Pokemonn pokemon)
        {
            context.Set<Pokemonn>().Remove(pokemon);
            await context.SaveChangesAsync();
        }

        public async Task<List<Pokemonn>> GetAllAsync()
        {
            return await context.Set<Pokemonn>().ToListAsync();
        }

        public async Task<Pokemonn> GetByIdAsync(int id)
        {
            return await context.Set<Pokemonn>().FindAsync(id);
        }
    }
}
