using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;

namespace Pibidex.Domain.Rules
{
    public class PokemonMustNotHaveSecondaryTypeToAddSecondaryTypeRule : IBusinessRule
    {
        private readonly int? _secondaryTypeId;

        public bool Condition => _secondaryTypeId is null;

        public PokemonMustNotHaveSecondaryTypeToAddSecondaryTypeRule(int? secondaryTypeId)
        {
            _secondaryTypeId = secondaryTypeId;
        }

        public void Enforce()
        {
            if (!Condition)
                throw new PokemonAlreadyHasSecondaryTypeException();
        }
    }
}