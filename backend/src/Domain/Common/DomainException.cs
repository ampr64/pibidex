using System;
using System.Runtime.Serialization;

namespace Pibidex.Domain.Common
{
    public abstract class DomainException : Exception
    {
        protected DomainException() : base("A domain exception has occurred.")
        {
        }

        protected DomainException(string? message) : base(message)
        {
        }

        protected DomainException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        protected DomainException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
