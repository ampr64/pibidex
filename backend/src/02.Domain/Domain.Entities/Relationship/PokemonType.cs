using Domain.Entities.Base;

namespace Domain.Entities.Relationship
{
    public class PokemonType : EntityBase<int>
    {
        public int PokemonId { get; set; }
        public int TypeId { get; set; }

        public Pokemon Pokemon { get; set; }
        public Type Type { get; set; }
    }
}