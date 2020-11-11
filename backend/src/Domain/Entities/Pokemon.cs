using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Rules;
using Pibidex.Domain.ValueObjects;

namespace Pibidex.Domain.Entities
{
    public class Pokemon : Entity<PokemonId>
    {
        public GenerationId GenerationId { get; set; } = null!;

        public Generation Generation { get; private set; } = null!;

        public PokemonSpeciesId SpeciesId { get; set; } = null!;

        public PokemonSpecies Species { get; private set; } = null!;

        public string? Description { get; private set; }

        public Height Height { get; private set; } = null!;

        public Weight Weight { get; private set; } = null!;

        public Url? ImageUrl { get; private set; }

        public PokemonTypeId PrimaryTypeId { get; private set; } = null!;

        public PokemonType PrimaryType { get; private set; } = null!;

        public PokemonTypeId? SecondaryTypeId { get; private set; }

        public PokemonType? SecondaryType { get; private set; }

        private Pokemon() { }

        public Pokemon(string name, GenerationId generationId, PokemonSpeciesId speciesId,
            Height height, Weight weight, PokemonTypeId primaryTypeId, PokemonTypeId? secondaryTypeId = null,
            Url? imageUrl = null, string? description = null) : base(name)
        {
            GenerationId = Guard.Against.Null(generationId, nameof(generationId));
            SpeciesId = Guard.Against.Null(speciesId, nameof(speciesId));
            Height = Guard.Against.Null(height, nameof(height));
            Weight = Guard.Against.Null(weight, nameof(weight));
            ImageUrl = imageUrl;
            SetDescription(description);
            SetTypes(primaryTypeId, secondaryTypeId);
        }

        public void SetDescription(string? description) => Description = description;

        public void UpdateDetails(Height height, Weight weight, Url? imageUrl)
        {
            Height = Guard.Against.Null(height, nameof(height));
            Weight = Guard.Against.Null(weight, nameof(weight));
            ImageUrl = imageUrl;
        }

        public void SetTypes(PokemonTypeId primaryTypeId, PokemonTypeId? secondaryTypeId)
        {
            PrimaryTypeId = Guard.Against.Null(primaryTypeId, nameof(primaryTypeId));
            SecondaryTypeId = secondaryTypeId;
        }
    }

    public class PokemonId : Id<PokemonId>
    {
        public PokemonId(int value) : base(value)
        {
        }
    }
}