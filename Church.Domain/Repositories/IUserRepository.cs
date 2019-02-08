using Church.Domain.Entities;
using System.Collections.Generic;

namespace Church.Domain.Repositories
{
    public interface IUserRepository
    {
        void Create(User user);
        void Edit(User user);
        User FindById(string id);
        List<User> GetAll();
        void Delete(string id);
        User Login(string email, string password);
    }
}
