using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Exceptions;

namespace Pibidex.Domain.Rules
{
    public class AuditableEntityMustBeTransientToSetCreationPropertiesRule : IBusinessRule
    {
        private readonly AuditableEntity _entity;

        public bool Condition => _entity.IsTransient() || _entity.CreatedBy is null;

        public AuditableEntityMustBeTransientToSetCreationPropertiesRule(AuditableEntity entity)
        {
            _entity = Guard.Against.Null(entity, nameof(entity));
        }

        public void Enforce()
        {
            if (!Condition)
                throw new AuditableEntityInvalidOperationException();
        }
    }
}