using System.Collections.Generic;

namespace Pibidex.Domain.Common
{
    public interface IHasDomainEvent
    {
        IReadOnlyList<DomainEvent> DomainEvents { get; }

        void AddDomainEvent(DomainEvent domainEvent);

        void ClearDomainEvents();
    }
}