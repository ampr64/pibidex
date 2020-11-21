using Pibidex.Domain.Common;
using Pibidex.Domain.Entities;
using Pibidex.Domain.Exceptions;
using Pibidex.Domain.Services;

namespace Pibidex.Domain.Rules
{
    public class PokemonSpeciesMustHaveUniqueDefaultFormRule : IBusinessRule
    {
        private readonly IPokemonSpeciesUniqueDefaultFormChecker _checker;
        private readonly PokemonSpeciesId _pokemonSpeciesId;

        public bool Condition => _checker.IsUnique(_pokemonSpeciesId);

        public PokemonSpeciesMustHaveUniqueDefaultFormRule(
            IPokemonSpeciesUniqueDefaultFormChecker checker,
            PokemonSpeciesId pokemonSpeciesId)
        {
            _checker = checker;
            _pokemonSpeciesId = pokemonSpeciesId;
        }

        public void Enforce()
        {
            if (!Condition)
                throw new PokemonSpeciesAlreadyHasDefaultFormException(_pokemonSpeciesId);
        }
    }
}