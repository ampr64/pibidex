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

        DbSet<SpeciesGroup> SpeciesGroups { get; set; }

        DbSet<PokemonForm> PokemonForms { get; set; }

        DbSet<PokemonSpecies> PokemonSpecies { get; set; }

        DbSet<PokemonType> PokemonTypes { get; set; }

        DbSet<Region> Regions { get; set; }

        Task<int> CommitChangesAsync(CancellationToken cancellationToken);
    }
}