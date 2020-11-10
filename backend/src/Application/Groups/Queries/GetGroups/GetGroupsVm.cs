using System.Collections.Generic;

namespace Pibidex.Application.Groups.Queries.GetGroups
{
    public class GetGroupsVm
    {
        public List<GroupDto> Groups { get; set; } = new();
    }
}