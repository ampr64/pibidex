using System;

namespace Pibidex.Domain.Common
{
    public abstract class DomainEvent
    {
        public DateTime OccurredOn => DateTime.UtcNow;

        public abstract void Publish();
    }
}