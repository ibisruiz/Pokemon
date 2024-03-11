using PokePoke.Core.Application.ViewModels.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Application.Interfaces.Services
{
    public interface IPokemonServices
    {
        Task<List<PokemonViewModel>> GetAllVm();
        Task Add(SavePokemonViewModel vm);
    }
}
