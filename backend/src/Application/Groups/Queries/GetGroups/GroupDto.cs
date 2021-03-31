using Pibidex.Application.Configuration.Mappings;
using Pibidex.Enumerations;

namespace Pibidex.Application.Groups.Queries.GetGroups
{
    public class GroupDto : IDto<SpeciesGroup>
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}