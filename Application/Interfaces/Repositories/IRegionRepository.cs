using PokePoke.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Application.Interfaces.Repositories
{
    public interface IRegionRepository
    {
        Task AddAsync(Region region);
        Task UpdateAsync(Region region);
        Task DeleteAsync(Region region);
        Task<List<Region>> GetAllAsync();
        Task<Region> GetByIdAsync(int id);
    }
}
