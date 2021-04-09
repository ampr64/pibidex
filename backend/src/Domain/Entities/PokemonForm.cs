using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.ValueObjects;

namespace Pibidex.Domain.Entities
{
    public class PokemonForm : Entity<PokemonFormId>
    {
        public GenerationId GenerationId { get; private set; } = null!;

        public Generation Generation { get; private set; } = null!;

        public PokedexNumber SpeciesId { get; private set; } = null!;

        public PokemonSpecies Species { get; private set; } = null!;

        public string? Description { get; private set; }

        public bool IsDefault { get; private set; }

        public Height Height { get; private set; } = null!;

        public Weight Weight { get; private set; } = null!;

        public Url? ImageUrl { get; private set; }

        public PokemonTypeId PrimaryTypeId { get; private set; } = null!;

        public PokemonType PrimaryType { get; private set; } = null!;

        public PokemonTypeId? SecondaryTypeId { get; private set; }

        public PokemonType? SecondaryType { get; private set; }

        private PokemonForm() { }

        private PokemonForm(
            string name,
            GenerationId generationId,
            PokedexNumber speciesId,
            Height height,
            Weight weight,
            PokemonTypeId primaryTypeId,
            PokemonTypeId? secondaryTypeId = null,
            Url? imageUrl = null,
            string? description = null,
            bool isDefault = false) : base(name)
        {
            GenerationId = Guard.Against.Null(generationId, nameof(generationId));
            SpeciesId = Guard.Against.Null(speciesId, nameof(speciesId));
            IsDefault = isDefault;
            Height = Guard.Against.Null(height, nameof(height));
            Weight = Guard.Against.Null(weight, nameof(weight));
            ImageUrl = imageUrl;
            Description = description;
            UpdateTypes(primaryTypeId, secondaryTypeId);
        }

        internal static PokemonForm CreateDefaultForm(
            string name,
            GenerationId generationId,
            PokedexNumber speciesId,
            Height height,
            Weight weight,
            PokemonTypeId primaryTypeId,
            PokemonTypeId? secondaryTypeId = null,
            Url? imageUrl = null,
            string? description = null)
        {
            return new PokemonForm(
                name,
                generationId,
                speciesId,
                height,
                weight,
                primaryTypeId,
                secondaryTypeId,
                imageUrl,
                description,
                true);
        }

        public void UpdateDetails(Height height, Weight weight, string? description, Url? imageUrl)
        {
            Height = Guard.Against.Null(height, nameof(height));
            Weight = Guard.Against.Null(weight, nameof(weight));
            Description = description;
            ImageUrl = imageUrl;
        }

        public void UpdateTypes(PokemonTypeId primaryTypeId, PokemonTypeId? secondaryTypeId)
        {
            PrimaryTypeId = Guard.Against.Null(primaryTypeId, nameof(primaryTypeId));
            SecondaryTypeId = secondaryTypeId;
        }
    }

    public class PokemonFormId : Id<PokemonFormId>
    {
        public PokemonFormId(int value) : base(value)
        {
        }
    }
}