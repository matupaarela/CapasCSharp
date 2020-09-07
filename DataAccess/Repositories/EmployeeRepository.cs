using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : MasterRepository, IEmployeeRepository
    {
        //Campos
        private string TSAll, TSInsert, TSUpdate, TSDestroy;
        //Prpiedades

        //Constructores
        public EmployeeRepository()
        {
            TSAll = "SELECT * FROM Employee";
            TSInsert = "INSERT INTO Employee VALUES (@number, @name, @mail, @birthay)";
            TSUpdate = "UPDATE Employee SET idNumber = @number, Name = @name, Mail = @mail, Birthay = @birthay WHERE idPK = @id";
            TSDestroy = "DELETE FROM Employee WHERE idPK = @id";
        }

        //Métodos o COmportamiento del Objeto
        public IEnumerable<Entities.Employee> All()
        {
            
        }

        public int Insert(Entities.Employee entity)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add("@id", entity.ID);
            Parameters.Add("@number", entity.Number);
            Parameters.Add("@name", entity.Name);
            Parameters.Add("@mail", entity.Email);
            Parameters.Add("@birthay", entity.Birthday);
        }

        public int Update(Entities.Employee entity)
        {
            throw new NotImplementedException();
        }

        public int Destroy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
