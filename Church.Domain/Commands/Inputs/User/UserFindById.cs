using Church.Shared.Commands;

namespace Church.Domain.Commands.Inputs.User
{
    public class UserFindById : ICommand
    {
        public string ID { get; set; }
    }
}
