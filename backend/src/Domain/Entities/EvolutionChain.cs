using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class EvolutionChain : Entity<EvolutionChainId>
    {
    }

    public class EvolutionChainId : Id<EvolutionChainId>
    {
        public EvolutionChainId(int value) : base(value)
        {
        }
    }
}