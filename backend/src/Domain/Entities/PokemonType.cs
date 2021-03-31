using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class PokemonType : Entity<PokemonTypeId>
    {
        public GenerationId GenerationId { get; private set; } = null!;

        public Generation Generation { get; private set; } = null!;

        private PokemonType() { }

        public PokemonType(GenerationId generationId, string name) : base(name) =>
            GenerationId = generationId;
    }

    public class PokemonTypeId : Id<PokemonTypeId>
    {
        public PokemonTypeId(int value) : base(value)
        {
        }
    }
}