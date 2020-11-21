using Pibidex.Application.Configuration.Commands;
using Pibidex.Application.Configuration.Data;
using Pibidex.Enumerations;
using System.Threading;
using System.Threading.Tasks;

namespace Pibidex.Application.Groups.Commands.CreateGroup
{
    public class CreateGroupCommandHandler : ICommandHandler<CreateGroupCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateGroupCommandHandler(IApplicationDbContext context) => _context = context;

        public async Task<int> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            var group = new PokemonSpeciesGroup((GroupId)request.Id, request.Name!);

            await _context.SpeciesGroups.AddAsync(group, cancellationToken)
                .ConfigureAwait(false);

            await _context.CommitChangesAsync(cancellationToken)
                .ConfigureAwait(false);

            return (int)group.Id;
        }
    }
}