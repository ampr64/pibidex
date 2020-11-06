using Pibidex.Domain.Common;

namespace Pibidex.Domain.Entities
{
    public class Region : Entity
    {
        public int GenerationId { get; private set; }

        public Generation Generation { get; private set; } = null!;

        public string? Description { get; private set; }

        private Region() { }

        public Region(string name, int generationId, string description) : base(name) =>
            (GenerationId, Description) = (generationId, description);
    }
}