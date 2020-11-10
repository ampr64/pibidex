using Pibidex.Application.Configuration.Commands;

namespace Pibidex.Application.Generations.Commands.CreateGeneration
{
    public class CreateGenerationCommand : ICommand<int>
    {
        public int Id { get; }
    }
}