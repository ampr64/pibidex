using FluentValidation;
using MediatR;
using Pibidex.Application.Configuration.Commands;
using Pibidex.Application.Configuration.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pibidex.Application.Configuration.Behaviors
{
    public class CommandValidationBehavior<TCommand, TResult> : IPipelineBehavior<TCommand, TResult>
        where TCommand : ICommand
    {
        private readonly IEnumerable<IValidator<TCommand>> _validators;

        public CommandValidationBehavior(IEnumerable<IValidator<TCommand>> validators) => _validators = validators;

        public async Task<TResult> Handle(TCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<TResult> next)
        {
            var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(request, cancellationToken)));
            var errors = validationResults.SelectMany(r => r.Errors).Where(e => e is not null).ToList();

            if (errors.Any())
                throw new InvalidCommandException(errors);

            return await next();
        }
    }
}