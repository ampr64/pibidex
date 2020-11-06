using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class PokemonType : Entity
    {
        public int GenerationId { get; private set; }

        public Generation Generation { get; private set; } = null!;

        private PokemonType() { }

        public PokemonType(int generationId, string name) : base(name) =>
            GenerationId = generationId;
    }
}