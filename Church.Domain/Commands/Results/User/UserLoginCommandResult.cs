using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.User
{
    public class UserLoginCommandResult : ICommandResult
    {
        public Entities.User User { get; set; }
    }
}
