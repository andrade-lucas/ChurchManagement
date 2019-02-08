using Church.Shared.Commands;
using System;

namespace Church.Domain.Commands.Inputs.User
{
    public class UserEdit : ICommand
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; private set; }
        public char Sex { get; private set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Permission { get; set; }
        public string Document { get; set; }
        public string Picture { get; set; }
    }
}
