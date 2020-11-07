using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class PokemonType : Entity<PokemonTypeId>
    {
        public int GenerationId { get; private set; }

        public Generation Generation { get; private set; } = null!;

        private PokemonType() { }

        public PokemonType(int generationId, string name) : base(name) =>
            GenerationId = generationId;
    }

    public class PokemonTypeId : Id<PokemonTypeId>
    {
        public PokemonTypeId(int value) : base(value)
        {
        }
    }
}