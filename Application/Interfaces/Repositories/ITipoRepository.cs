using Microsoft.EntityFrameworkCore;
using PokePoke.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Application.Interfaces.Repositories
{
    public interface ITipoRepository
    {
        Task AddAsync(Tipo tipo);

        Task UpdateAsync(Tipo tipo);

        Task DeleteAsync(Tipo tipo);

        Task<List<Tipo>> GetAllAsync();

        Task<Tipo> GetByIdAsync(int id);

    }
}
