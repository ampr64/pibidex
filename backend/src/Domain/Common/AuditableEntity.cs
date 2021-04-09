using System;

namespace Pibidex.Domain.Common
{
    public abstract class AuditableEntity<TId> : Entity<TId>
        where TId : Id<TId>
    {
        public DateTime CreatedOn { get; private set; }

        public string? CreatedBy { get; private set; }

        public DateTime? LastModifiedOn { get; private set; }

        public string? LastModifiedBy { get; private set; }

        protected AuditableEntity() { }

        protected AuditableEntity(string? createdBy = null)
        {
            CreatedOn = DateTime.UtcNow;
            CreatedBy = createdBy;
        }

        public void Update(string? modifiedBy)
        {
            LastModifiedOn = DateTime.UtcNow;
            LastModifiedBy = modifiedBy;
        }
    }
}