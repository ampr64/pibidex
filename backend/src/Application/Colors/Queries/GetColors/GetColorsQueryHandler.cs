using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pibidex.Application.Configuration.Data;
using Pibidex.Application.Configuration.Queries;
using Pibidex.Domain.Enumeration;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pibidex.Application.Colors.Queries.GetColors
{
    public class GetColorsQueryHandler : IQueryHandler<GetColorsQuery, GetColorsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetColorsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetColorsVm> Handle(GetColorsQuery query, CancellationToken cancellationToken)
        {
            var result = new GetColorsVm
            {
                Colors = await _context.Colors
                    .ProjectTo<ColorDto>(_mapper.ConfigurationProvider)
                    .OrderBy(c => c.Id)
                    .ToListAsync(cancellationToken)
            };

            if (!result.Colors.Any())
            {
                result.Colors = GetPrefixedColors()
                    .OrderBy(c => c.Id)
                    .Select(c => _mapper.Map<ColorDto>(c))
                    .ToList();
            }

            return result;
        }

        private IEnumerable<Color> GetPrefixedColors() => Color.GetAll();
    }
}