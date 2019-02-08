using Church.Shared.Commands;

namespace Church.Domain.Commands.Inputs.User
{
    public class UserDelete : ICommand
    {
        public string ID { get; set; }
    }
}
