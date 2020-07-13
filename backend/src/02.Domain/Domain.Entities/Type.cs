using Domain.Entities.Relationship;
using Domain.Entities.Base;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Type : EntityBase<int>
    {
        public IList<PokemonType> PokemonTypes { get; set; }
    }
}