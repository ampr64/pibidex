using Pibidex.Application.Configuration.Commands;

namespace Pibidex.Application.Generations.Commands.CreateGeneration
{
    public class CreateGenerationCommand : ICommand<int>
    {
        public int Id { get; }

        public string Name { get; }

        public CreateGenerationCommand(int id, string name) =>
            (Id, Name) = (id, name);
    }
}