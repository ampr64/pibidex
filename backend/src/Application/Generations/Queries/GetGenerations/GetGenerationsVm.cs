using System.Collections.Generic;

namespace Pibidex.Application.Generations.Queries.GetGenerations
{
    public class GetGenerationsVm
    {
        public List<GenerationDto> Generations { get; set; } = new();
    }
}