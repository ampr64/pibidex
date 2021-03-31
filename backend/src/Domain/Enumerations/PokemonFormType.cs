using Pibidex.Domain.Common;

namespace Pibidex.Domain.Enumerations
{
    public class PokemonFormType : Enumeration<PokemonFormType>
    {
        public static readonly PokemonFormType Default = new PokemonFormType(1, nameof(Default));
        public static readonly PokemonFormType Alolan = new PokemonFormType(2, nameof(Alolan));
        public static readonly PokemonFormType Galarian = new PokemonFormType(3, nameof(Galarian));
        public static readonly PokemonFormType Mega = new PokemonFormType(4, nameof(Mega));
        public static readonly PokemonFormType Gigantamax = new PokemonFormType(5, nameof(Gigantamax));

        public PokemonFormType(int id, string name) : base(id, name) { }
    }
}