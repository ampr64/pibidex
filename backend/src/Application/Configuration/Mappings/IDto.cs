using AutoMapper;

namespace Pibidex.Application.Configuration.Mappings
{
    public interface IDto<T>
    {
        void Map(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}