using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pibidex.Application.Configuration.Data;
using Pibidex.Application.Configuration.Queries;
using Pibidex.Enumerations;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pibidex.Application.Groups.Queries.GetGroups
{
    public class GetGroupsQueryHandler : IQueryHandler<GetGroupsQuery, GetGroupsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetGroupsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetGroupsVm> Handle(GetGroupsQuery request, CancellationToken cancellationToken)
        {
            var result = new GetGroupsVm
            {
                Groups = await _context.Groups
                    .ProjectTo<GroupDto>(_mapper.ConfigurationProvider)
                    .OrderBy(g => g.Id)
                    .ToListAsync(cancellationToken)
            };

            if (!result.Groups.Any())
            {
                result.Groups = GetPrefixedGroups()
                    .OrderBy(g => g.Id)
                    .Select(g => _mapper.Map<GroupDto>(g))
                    .ToList();
            }

            return result;
        }

        public IEnumerable<Group> GetPrefixedGroups() => Group.GetAll();
    }
}