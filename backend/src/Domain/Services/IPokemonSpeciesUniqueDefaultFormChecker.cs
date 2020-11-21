using Pibidex.Domain.Entities;

namespace Pibidex.Domain.Services
{
    public interface IPokemonSpeciesUniqueDefaultFormChecker
    {
        bool IsUnique(PokemonSpeciesId pokemonSpeciesId);
    }
}