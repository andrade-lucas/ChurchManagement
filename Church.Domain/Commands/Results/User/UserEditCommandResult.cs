using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.User
{
    public class UserEditCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
