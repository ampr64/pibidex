using Pibidex.Domain.Common;

namespace Pibidex.Domain.Exceptions
{
    public class AuditableEntityInvalidOperationException : DomainException
    {
        public AuditableEntityInvalidOperationException()
            : base("Cannot set creation properties to existing entity.")
        {
        }
    }
}