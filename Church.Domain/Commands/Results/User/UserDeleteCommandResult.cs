using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.User
{
    public class UserDeleteCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
