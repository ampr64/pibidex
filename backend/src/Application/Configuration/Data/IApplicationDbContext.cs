using Microsoft.EntityFrameworkCore;
using Pibidex.Domain.Entities;
using Pibidex.Domain.Enumeration;
using Pibidex.Enumerations;
using System.Threading;
using System.Threading.Tasks;

namespace Pibidex.Application.Configuration.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Ability> Abilities { get; set; }

        DbSet<Category> Categories { get; set; }

        DbSet<Color> Colors { get; set; }

        DbSet<Generation> Generations { get; set; }

        DbSet<Group> Groups { get; set; }

        DbSet<Pokemon> Pokemons { get; set; }

        DbSet<PokemonSpecies> Species { get; set; }

        DbSet<PokemonType> Types { get; set; }

        DbSet<Region> Regions { get; set; }

        Task<int> CommitChangesAsync(CancellationToken cancellationToken);
    }
}