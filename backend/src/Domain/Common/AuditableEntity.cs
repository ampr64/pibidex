using Ardalis.GuardClauses;
using Pibidex.Domain.Rules;
using System;

namespace Pibidex.Domain.Common
{
    public abstract class AuditableEntity<TId> : Entity<TId>
        where TId : Id<TId>
    {
        public DateTime CreatedOn { get; protected set; }

        public string? CreatedBy { get; protected set; }

        public DateTime? LastModifiedOn { get; protected set; }

        public string? LastModifiedBy { get; protected set; }

        protected AuditableEntity() { }

        protected AuditableEntity(DateTime createdOn, string? createdBy = null)
        {
            SetCreationProperties(createdOn, createdBy);
        }

        public void SetCreationProperties(DateTime createdOn, string? createdBy)
        {
            new AuditableEntityMustBeTransientToSetCreationPropertiesRule<TId>(this).Enforce();

            CreatedOn = createdOn;
            CreatedBy = createdBy;
        }

        public void SetUpdateProperties(DateTime lastModifiedOn, string lastModifiedBy)
        {
            LastModifiedOn = Guard.Against.Default(lastModifiedOn, nameof(lastModifiedOn));
            LastModifiedBy = Guard.Against.NullOrEmpty(lastModifiedBy, nameof(lastModifiedBy));
        }
    }
}