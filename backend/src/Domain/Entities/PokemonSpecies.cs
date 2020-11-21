using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Enumeration;
using Pibidex.Enumerations;
using System.Collections.Generic;

namespace Pibidex.Domain.Entities
{
    public class PokemonSpecies : Entity<PokemonSpeciesId>
    {
        public CategoryId CategoryId { get; private set; } = null!;

        public Category Category { get; private set; } = null!;

        public int ColorId { get; private set; }

        public Color Color { get; private set; } = null!;

        public EvolutionChainId? EvolutionChainId { get; private set; }

        public EvolutionChain? EvolutionChain { get; private set; }

        public PokemonSpeciesId? ParentSpeciesId { get; private set; }

        public GroupId GroupId { get; private set; } = null!;

        public string Description { get; private set; } = null!;

        private readonly List<PokemonForm> _forms = new();

        public IReadOnlyCollection<PokemonForm> Forms => _forms.AsReadOnly();

        private PokemonSpecies() { }

        public PokemonSpecies(PokemonSpeciesId id,
                       string name,
                       CategoryId categoryId,
                       int colorId,
                       GroupId groupId,
                       string description,
                       EvolutionChainId? evolutionChainId = null,
                       PokemonSpeciesId? parentSpeciesId = null)
            : base(id, name)
        {
            CategoryId = Guard.Against.Null(categoryId, nameof(categoryId));
            ColorId = Guard.Against.NegativeOrZero(colorId, nameof(colorId));
            EvolutionChainId = evolutionChainId;
            ParentSpeciesId = parentSpeciesId;
            GroupId = Guard.Against.Null(groupId, nameof(groupId));
            Description = Guard.Against.NullOrWhiteSpace(description, nameof(description));
        }

        public void AddDefaultForm()
        {

        }

        public void AddForm()
        {

        }
    }

    public class PokemonSpeciesId : Id<PokemonSpeciesId>
    {
        public PokemonSpeciesId(int value)
            : base(value)
        {
        }
    }
}