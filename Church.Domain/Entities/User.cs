using Church.Domain.ValueObjects;
using Church.Shared.Entities;
using System;

namespace Church.Domain.Entities
{
    public class User : Person
    {
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public bool Status { get; private set; }
        public string Permission { get; private set; }
        public Document Document { get; private set; }

        public User()
        {
        }

        public User(string id, string firstName, string lastName, DateTime birthdate, char sex, Email email, string password, bool status, string permission, Document document, string picture) 
            : base(id, firstName, lastName, birthdate, sex, picture)
        {
            Email = email;
            Password = password;
            Status = status;
            Permission = permission;
            Document = document;
        }
    }
}
