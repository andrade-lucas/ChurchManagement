using Church.Shared.Commands;
using System.Collections.Generic;

namespace Church.Domain.Commands.Results.User
{
    public class UserGetAllCommandResult : ICommandResult
    {
        public List<Entities.User> Users { get; set; }
    }
}
