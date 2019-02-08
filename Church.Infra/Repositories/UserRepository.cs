using Church.Domain.Entities;
using Church.Domain.Repositories;
using Church.Infra.Context;
using System;
using System.Collections.Generic;

namespace Church.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IDB DB;

        public UserRepository(IDB db)
        {
            DB = db;
        }

        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(User user)
        {
            throw new NotImplementedException();
        }

        public User FindById(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
