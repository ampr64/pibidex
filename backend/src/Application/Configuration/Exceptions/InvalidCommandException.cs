using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pibidex.Application.Configuration.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public IDictionary<string, string[]> Errors { get; }

        public InvalidCommandException(IEnumerable<ValidationFailure> errors) : this()
        {
            foreach (var errorGroup in errors.GroupBy(e => e.PropertyName, e => e.ErrorMessage))
            {
                var propertyName = errorGroup.Key;
                var propertyErrors = errorGroup.ToArray();

                Errors.Add(errorGroup.Key, propertyErrors);
            }
        }

        private InvalidCommandException() : base("Invalid command: one or more validation failures have occurred.")
        {
            Errors = new Dictionary<string, string[]>();
        }
    }
}