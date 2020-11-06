using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Enumeration;
using System.Collections.Generic;

namespace Pibidex.Domain.Entities
{
    public class Species : Entity
    {
        public int CategoryId { get; private set; }

        public Category Category { get; private set; } = null!;

        public int ColorId { get; private set; }

        public Color Color { get; private set; } = null!;

        public int? EvolutionChainId { get; private set; }

        public EvolutionChain? EvolutionChain { get; private set; } = null!;

        public int? ParentSpeciesId { get; private set; }

        public Species? ParentSpecies { get; private set; }

        public int GroupId { get; private set; }

        public string? Description { get; private set; }

        private readonly List<Pokemon> _pokemons = new();
        public IReadOnlyCollection<Pokemon> Pokemons => _pokemons.AsReadOnly();

        private Species() { }
        
        public Species(int id,
                       string name,
                       int categoryId,
                       int colorId,
                       int evolutionChainId,
                       int parentSpeciesId,
                       int groupId,
                       string description) : base(name)
        {
            Id = Guard.Against.NegativeOrZero(id, nameof(id));
            CategoryId = Guard.Against.NegativeOrZero(categoryId, nameof(categoryId));
            ColorId = Guard.Against.NegativeOrZero(colorId, nameof(colorId));
            EvolutionChainId = Guard.Against.NegativeOrZero(evolutionChainId, nameof(evolutionChainId));
            ParentSpeciesId = Guard.Against.NegativeOrZero(parentSpeciesId, nameof(parentSpeciesId));
            GroupId = Guard.Against.NegativeOrZero(groupId, nameof(groupId));
            Description = description;
        }
    }
}