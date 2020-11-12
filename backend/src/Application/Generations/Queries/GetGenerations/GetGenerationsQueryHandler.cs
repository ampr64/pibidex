using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pibidex.Application.Configuration.Data;
using Pibidex.Application.Configuration.Queries;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pibidex.Application.Generations.Queries.GetGenerations
{
    public class GetGenerationsQueryHandler : IQueryHandler<GetGenerationsQuery, GetGenerationsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetGenerationsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetGenerationsVm> Handle(GetGenerationsQuery request, CancellationToken cancellationToken)
        {
            return new GetGenerationsVm
            {
                Generations = await _context.Generations
                    .ProjectTo<GenerationDto>(_mapper.ConfigurationProvider)
                    .OrderBy(g => g.Id)
                    .ToListAsync()
            };
        }
    }
}