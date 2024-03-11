using PokePoke.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Application.Interfaces.Repositories
{
    public interface IPokemonRepository
    {
        Task AddAsync(Pokemonn pokemon);
        Task UpdateAsync(Pokemonn pokemon);
        Task DeleteAsync(Pokemonn pokemon);
        Task<List<Pokemonn>> GetAllAsync();
        Task<Pokemonn> GetByIdAsync(int id);
    }
}
