using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.User
{
    public class UserCreateCommandResult : ICommandResult
    {
        public string Message { get; set; }
    }
}
