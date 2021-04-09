using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Enumeration;
using Pibidex.Enumerations;
using System.Collections.Generic;

namespace Pibidex.Domain.Entities
{
    public class PokemonSpecies : Entity<PokedexNumber>
    {
        public CategoryId CategoryId { get; private set; } = null!;

        public Category Category { get; private set; } = null!;

        public string Color { get; private set; }

        public EvolutionChainId? EvolutionChainId { get; private set; }

        public EvolutionChain? EvolutionChain { get; private set; }

        public PokedexNumber? ParentSpeciesId { get; private set; }

        public GroupId GroupId { get; private set; } = null!;

        public string Description { get; private set; } = null!;

        private readonly List<PokemonForm> _forms = new();
        public IReadOnlyList<PokemonForm> Forms => _forms.AsReadOnly();

        private PokemonSpecies() { }

        public PokemonSpecies(
            PokedexNumber id,
            string name,
            CategoryId categoryId,
            Color color,
            GroupId groupId,
            string description,
            EvolutionChainId? evolutionChainId = null,
            PokedexNumber? parentSpeciesId = null)
            : base(id, name)
        {
            CategoryId = Guard.Against.Null(categoryId, nameof(categoryId));
            Color = Guard.Against.Null(color, nameof(color)).Name;
            EvolutionChainId = evolutionChainId;
            ParentSpeciesId = parentSpeciesId;
            GroupId = Guard.Against.Null(groupId, nameof(groupId));
            Description = Guard.Against.NullOrWhiteSpace(description, nameof(description));
        }

        public void AddForm()
        {
        }
    }

    public class PokedexNumber : Id<PokedexNumber>
    {
        public PokedexNumber(int value) : base(value)
        {
        }
    }
}