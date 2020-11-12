using AutoMapper;
using Pibidex.Domain.Common;
using System;

namespace Pibidex.Application.Configuration.Mappings
{
    public class IdToIntConverter : ITypeConverter<IId, int>
    {
        public int Convert(IId source, int destination, ResolutionContext context) => source.Value;
    }

    public class IntToIdConverter : ITypeConverter<int, IId>
    {
        public IId Convert(int source, IId destination, ResolutionContext context) => (IId)Activator.CreateInstance(typeof(IId), source)!;
    }
}