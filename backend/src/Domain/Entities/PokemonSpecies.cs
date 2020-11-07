using Ardalis.GuardClauses;
using Pibidex.Domain.Common;
using Pibidex.Domain.Enumeration;
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

        public int GroupId { get; private set; }

        public string? Description { get; private set; }

        private readonly List<Pokemon> _pokemons = new();
        public IReadOnlyCollection<Pokemon> Pokemons => _pokemons.AsReadOnly();

        private PokemonSpecies() { }
        
        public PokemonSpecies(PokemonSpeciesId id,
                       string name,
                       CategoryId categoryId,
                       int colorId,
                       int groupId,
                       EvolutionChainId? evolutionChainId = null,
                       PokemonSpeciesId? parentSpeciesId = null,
                       string? description = null) : base(name)
        {
            Id = Guard.Against.Null(id, nameof(id));
            CategoryId = Guard.Against.Null(categoryId, nameof(categoryId));
            ColorId = Guard.Against.NegativeOrZero(colorId, nameof(colorId));
            EvolutionChainId = evolutionChainId;
            ParentSpeciesId = parentSpeciesId;
            GroupId = Guard.Against.NegativeOrZero(groupId, nameof(groupId));
            Description = description;
        }


    }

    public class PokemonSpeciesId : Id<PokemonSpeciesId>
    {
        public PokemonSpeciesId(int value) : base(value)
        {
        }
    }
}