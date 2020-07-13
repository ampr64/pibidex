using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Species : EntityBase<int>
    {
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public int DefaultPokemonId { get; set; }
        public int EvolutionChainId { get; set; }
        public int ParentSpeciesId { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }
        public Color Color { get; set; }
        public Pokemon DefaultPokemon { get; set; }
        public EvolutionChain EvolutionChain { get; set; }
        public Species ParentSpecies { get; set; }
        public IList<Pokemon> Pokemons { get; set; }
    }
}