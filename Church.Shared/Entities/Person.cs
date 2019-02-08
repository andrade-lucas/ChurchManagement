using System;

namespace Church.Shared.Entities
{
    public abstract class Person : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthdate { get; private set; }
        public char Sex { get; private set; }
        public string Picture { get; private set; }

        public Person()
        {
        }

        public Person(string id, string firstName, string lastName, DateTime birthdate, char sex, string picture) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Sex = sex;
            Picture = picture;
        }
    }
}
