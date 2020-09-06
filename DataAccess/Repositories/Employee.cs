using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class Employee : MasterRepository, IEmployeeRepository
    {
        private string TSAll;
        public IEnumerable<Entities.Employee> All()
        {
            throw new NotImplementedException();
        }

        public int Destroy(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Entities.Employee entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Entities.Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
