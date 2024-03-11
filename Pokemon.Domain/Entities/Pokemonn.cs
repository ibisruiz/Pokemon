using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Domain.Entities
{
    public class Pokemonn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public ICollection<PokemonTipo> PokemonesTipos { get; set; }




    }
}
