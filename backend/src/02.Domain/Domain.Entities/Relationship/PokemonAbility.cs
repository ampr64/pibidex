using Domain.Entities.Base;

namespace Domain.Entities.Relationship
{
    public class PokemonAbility : EntityBase<int>
    {
        public int AbilityId { get; set; }
        public int PokemonId { get; set; }

        public Ability Ability { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}