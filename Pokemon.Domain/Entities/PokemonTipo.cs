using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Domain.Entities
{
    public class PokemonTipo
    {
        public int PokemonId { get; set; }
        public int TipoId { get; set; }
        public int Order {  get; set; }

        public Pokemonn Pokemon { get; set; }
        public Tipo Tipo { get; set; }
    }
}
