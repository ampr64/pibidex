using Domain.Entities.Relationship;
using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Pokemon : EntityBase<int>
    {
        public int GenerationId { get; set; }
        public int SpeciesId { get; set; }

        public string Description { get; set; }
        public decimal Height { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public decimal Weight { get; set; }

        public IList<PokemonAbility> PokemonAbilities { get; set; }
        public Generation Generation { get; set; }
        public IList<PokemonType> PokemonTypes { get; set; }
        public Species Species { get; set; }
    }
}