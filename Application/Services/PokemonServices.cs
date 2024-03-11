using PokePoke.Core.Application.Interfaces.Repositories;
using PokePoke.Core.Application.Interfaces.Services;
using PokePoke.Core.Application.ViewModels.Pokemon;
using PokePoke.Core.Domain.Entities;

namespace PokePoke.Core.Application.Services
{
    public class PokemonServices : IPokemonServices
    {
        private readonly IPokemonRepository pokemonRepository;

        public PokemonServices(IPokemonRepository pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;        
        }

        public async Task<List<PokemonViewModel>> GetAllVm()
        {
            var pokemonList = await pokemonRepository.GetAllAsync();

            return pokemonList.Select(pokemon => new PokemonViewModel
            {
                Name = pokemon.Name,
                ImageUrl = pokemon.ImageUrl
            }).ToList();
        }

        public async Task Add(SavePokemonViewModel vm)
        {
            Pokemonn pokemonn = new Pokemonn();
            pokemonn.Id = vm.Id;
            pokemonn.Name = vm.Name;
            pokemonn.ImageUrl = vm.ImageUrl;
            pokemonn.RegionId = vm.RegionId;

            var resultado = new List<PokemonTipo>();

            foreach (var tipoIds in vm.TiposIds)
            {
                resultado.Add(new PokemonTipo() { TipoId = tipoIds });                
            }

            await pokemonRepository.AddAsync(pokemonn);
        }
    }
}
