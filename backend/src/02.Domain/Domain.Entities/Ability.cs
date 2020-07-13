using Domain.Entities.Base;
using Domain.Entities.Relationship;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Ability : EntityBase<int>
    {
        public string Description { get; set; }

        public IList<PokemonAbility> PokemonAbilities { get; set; }
    }
}