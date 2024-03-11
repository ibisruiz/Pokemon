﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePoke.Core.Domain.Entities
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PokemonTipo> PokemonesTipos { get; set; }

    }
}
