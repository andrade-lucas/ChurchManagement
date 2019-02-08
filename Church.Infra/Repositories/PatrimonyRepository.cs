using Church.Domain.Entities;
using Church.Domain.Repositories;
using Church.Infra.Context;
using System;
using System.Collections.Generic;

namespace Church.Infra.Repositories
{
    public class PatrimonyRepository : IGenericRepository<Patrimony>
    {
        private IDB DB;

        public PatrimonyRepository(IDB db)
        {
            DB = db;
        }

        public void Create(Patrimony entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Patrimony entity)
        {
            throw new NotImplementedException();
        }

        public Patrimony FindById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Patrimony> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
