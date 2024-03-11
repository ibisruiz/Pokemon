using PokePoke.Core.Application.ViewModels.Region;
using PokePoke.Core.Application.ViewModels.Tipo;

namespace PokePoke.Core.Application.ViewModels.Pokemon
{
    public class SavePokemonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public int RegionId { get; set; }

        public List<int> TiposIds { get; set; }

        public List<RegionViewModel>? Regiones { get; set; }

        public List<TipoViewModel>? Tipos { get; set; }
    }
}
