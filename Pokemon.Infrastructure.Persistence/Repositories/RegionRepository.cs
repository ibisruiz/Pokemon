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
    public class RegionRepository : IRegionRepository
    {
        private readonly ApplicationContext context;

        public RegionRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Region region)
        {
            await context.Regions.AddAsync(region);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Region region)
        {
            context.Entry(region).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Region region)
        {
            context.Set<Region>().Remove(region);
            await context.SaveChangesAsync();
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await context.Set<Region>().ToListAsync();
        }

        public async Task<Region> GetByIdAsync(int id)
        {
            return await context.Set<Region>().FindAsync(id);
        }
    }
}
