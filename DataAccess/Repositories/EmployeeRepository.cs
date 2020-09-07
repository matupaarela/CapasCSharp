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
            TSInsert = "INSERT INTO Employee VALUES (@number, @name, @mail, @birthday)";
            TSUpdate = "UPDATE Employee SET idNumber = @number, Name = @name, Mail = @mail, Birthday = @birthday WHERE idPK = @id";
            TSDestroy = "DELETE FROM Employee WHERE idPK = @id";
        }

        //Métodos o COmportamiento del Objeto
        public IEnumerable<Entities.Employee> All()
        {
            var TableResult = ExecuteReader(TSAll);
            var ListEmployee = new List<Employee>();
            foreach(DataRow Row in TableResult.Rows)
            {
                ListEmployee.Add(new Employee {
                    ID = Convert.ToInt32(Row[0]),
                    Number = Row[1].ToString(),
                    Name = Row[2].ToString(),
                    Email = Row[3].ToString(),
                    Birthday = Convert.ToDateTime(Row[4])
                });
            }
            return ListEmployee;
        }

        public int Insert(Entities.Employee entity)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@number", entity.Number));
            Parameters.Add(new SqlParameter("@name", entity.Name));
            Parameters.Add(new SqlParameter("@mail", entity.Email));
            Parameters.Add(new SqlParameter("@birthday", entity.Birthday));
            return ExecuteNonQuery(TSInsert);
        }

        public int Update(Entities.Employee entity)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", entity.ID));
            Parameters.Add(new SqlParameter("@number", entity.Number));
            Parameters.Add(new SqlParameter("@name", entity.Name));
            Parameters.Add(new SqlParameter("@mail", entity.Email));
            Parameters.Add(new SqlParameter("@birthday", entity.Birthday));
            return ExecuteNonQuery(TSUpdate);
        }

        public int Destroy(int id)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(TSDestroy);
        }
    }
}
