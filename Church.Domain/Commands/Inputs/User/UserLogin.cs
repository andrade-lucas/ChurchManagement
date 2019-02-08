using Church.Shared.Commands;

namespace Church.Domain.Commands.Inputs.User
{
    public class UserLogin : ICommand
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
