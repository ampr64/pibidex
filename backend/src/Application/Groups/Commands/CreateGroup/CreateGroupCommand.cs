using Pibidex.Application.Configuration.Commands;

namespace Pibidex.Application.Groups.Commands.CreateGroup
{
    public class CreateGroupCommand : ICommand<int>
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}