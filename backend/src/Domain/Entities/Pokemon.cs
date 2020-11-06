using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Rules;
using Pibidex.Domain.ValueObjects;

namespace Pibidex.Domain.Entities
{
    public class Pokemon : Entity
    {
        public int GenerationId { get; private set; }

        public Generation Generation { get; private set; } = null!;

        public int SpeciesId { get; private set; }

        public Species Species { get; private set; } = null!;

        public string? Description { get; private set; }

        public Height Height { get; private set; } = null!;

        public Weight Weight { get; private set; } = null!;

        public Url ImageUrl { get; private set; } = null!;

        public int PrimaryTypeId { get; private set; }

        public PokemonType PrimaryType { get; private set; } = null!;

        public int? SecondaryTypeId { get; private set; }

        public PokemonType? SecondaryType { get; private set; }

        private Pokemon() { }

        public Pokemon(string name, int generationId, int speciesId, string? description, Height height,
            Weight weight, Url imageUrl, int primaryTypeId, int? secondaryTypeId = null) : base(name)
        {
            GenerationId = Guard.Against.NegativeOrZero(generationId, nameof(generationId));
            SpeciesId = Guard.Against.NegativeOrZero(speciesId, nameof(speciesId));
            Description = description;
            Height = Guard.Against.Null(height, nameof(height));
            Weight = Guard.Against.Null(weight, nameof(weight));
            ImageUrl = Guard.Against.Null(imageUrl, nameof(imageUrl));
            PrimaryTypeId = Guard.Against.NegativeOrZero(primaryTypeId, nameof(primaryTypeId));
            SecondaryTypeId = secondaryTypeId;
        }

        public void SetDescription(string? description) => Description = description;

        public void UpdateDetails(Height height, Weight weight, Url imageUrl)
        {
            Height = Guard.Against.Null(height, nameof(height));
            Weight = Guard.Against.Null(weight, nameof(weight));
            ImageUrl = Guard.Against.Null(imageUrl, nameof(imageUrl));
        }

        public void ChangePrimaryType(int primaryTypeId) =>
            PrimaryTypeId = Guard.Against.NegativeOrZero(primaryTypeId, nameof(primaryTypeId));

        public void AddSecondaryType(int secondaryTypeId)
        {
            new PokemonMustNotHaveSecondaryTypeToAddSecondaryTypeRule(secondaryTypeId).Enforce();
            SecondaryTypeId = Guard.Against.NegativeOrZero(secondaryTypeId, nameof(secondaryTypeId));
        }
    }
}