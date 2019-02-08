using Church.Shared.Commands;

namespace Church.Domain.Commands.Results.User
{
    public class UserFindByIdCommandResult : ICommandResult
    {
        public Entities.User User { get; set; }
    }
}
