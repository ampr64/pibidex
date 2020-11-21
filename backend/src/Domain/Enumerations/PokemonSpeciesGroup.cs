using Pibidex.Domain.Common;

namespace Pibidex.Enumerations
{
    public class PokemonSpeciesGroup : Enumeration<PokemonSpeciesGroup, GroupId>
    {
        public static readonly PokemonSpeciesGroup Common = new PokemonSpeciesGroup((GroupId)1, nameof(Common));
        public static readonly PokemonSpeciesGroup Baby = new PokemonSpeciesGroup((GroupId)2, nameof(Baby));
        public static readonly PokemonSpeciesGroup Starter = new PokemonSpeciesGroup((GroupId)3, nameof(Starter));
        public static readonly PokemonSpeciesGroup Legendary = new PokemonSpeciesGroup((GroupId)4, nameof(Legendary));
        public static readonly PokemonSpeciesGroup Mythical = new PokemonSpeciesGroup((GroupId)5, nameof(Mythical));

        public PokemonSpeciesGroup(GroupId id, string name)
            : base(id, name)
        {
        }
    }

    public class GroupId : Id<GroupId>
    {
        public GroupId(int value) : base(value)
        {
        }
    }
}