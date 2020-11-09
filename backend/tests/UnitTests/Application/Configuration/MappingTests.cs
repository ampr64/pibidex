using AutoMapper;
using AutoMapper.Configuration;
using Pibidex.Application.Colors.Queries.GetColors;
using Pibidex.Application.Configuration.Mappings;
using Pibidex.Domain.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Pibidex.UnitTests.Application.Configuration
{
    public class MappingTests
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public MappingTests()
        {
            _configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ApplicationProfile>();
            });

            _mapper = _configuration.CreateMapper();
        }

        [Fact]
        public void HasValidConfiguration()
        {
            _configuration.AssertConfigurationIsValid();
        }

        [Fact]
        public void MapsFromSourceToDestinationCorrectly()
        {
            var source = Color.Black;

            var expectedDto = new ColorDto { Id = Color.Black.Id, Name = Color.Black.Name };

            var actualDto = _mapper.Map<Color, ColorDto>(source);

            Assert.Equal(expectedDto.Id, actualDto.Id);
            Assert.Equal(expectedDto.Name, actualDto.Name);
        }
    }
}