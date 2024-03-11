using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Domain.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Pokemonn> Pokemones { get; set; }
    }
}
