using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Pibidex.Application.Configuration.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Pibidex.Application.Groups.Commands.CreateGroup
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateGroupCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(g => g.Name)
                .NotEmpty().WithMessage($"Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(g => g.Id)
                .GreaterThan(0)
                .WithMessage("Id must be a positive number");

            RuleFor(g => new { g.Id, g.Name })
                .MustAsync((item, ct) => BeUniqueIdAndName(item.Id, item.Name!, ct));
        }

        private async Task<bool> BeUniqueIdAndName(int id, string name, CancellationToken cancellationToken) =>
            !await _context.SpeciesGroups
                .AnyAsync(g => (int)g.Id == id || g.Name.ToLower() == name.ToLower());
    }
}