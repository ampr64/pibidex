using Pibidex.Domain.Common;

namespace Pibidex.Domain.Exceptions
{
    public class PokemonAlreadyHasSecondaryTypeException : DomainException
    {
        public PokemonAlreadyHasSecondaryTypeException()
            : base("Cannot add secondary type to this Pokémon, as it already has one.")
        {
        }
    }
}