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
    public class TipoRepository: ITipoRepository
    {
        private readonly ApplicationContext context;

        public TipoRepository(ApplicationContext context)
        {
            this.context = context;     
        }

        public async Task AddAsync(Tipo tipo)
        {
            await context.Tipos.AddAsync(tipo);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tipo tipo)
        {
            context.Entry(tipo).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Tipo tipo)
        {
            context.Set<Tipo>().Remove(tipo);
            await context.SaveChangesAsync();
        }

        public async Task<List<Tipo>> GetAllAsync()
        {
            return await context.Set<Tipo>().ToListAsync();
        }

        public async Task<Tipo> GetByIdAsync(int id)
        {
            return await context.Set<Tipo>().FindAsync(id);
        }

    }
}
