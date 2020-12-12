using Common.Entities;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        //Implementar otros métodos aparte del crud
        bool Login(string username, string password);
    }
}
