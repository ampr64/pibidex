using Pibidex.Domain.Common;
using Pibidex.Domain.Entities;

namespace Pibidex.Domain.Exceptions
{
    public class PokemonSpeciesAlreadyHasDefaultFormException : DomainException
    {
        public PokemonSpeciesAlreadyHasDefaultFormException(PokemonSpeciesId id)
            : base($"Pokemon species with id {id} already has a default form set.")
        {
        }
    }
}