using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess.Repositories
{
    public abstract class MasterRepository:Repository
    {
        protected List<SqlParameter> Parameters;

        protected int ExecuteNonQuery(string TransacSQL)
        {
            using(var Connection = GetConnection())
            {
                Connection.Open();
                using (SqlCommand Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandText = TransacSQL;
                    Command.CommandType = CommandType.Text;
                    foreach(SqlParameter Param in Parameters)
                    {
                        Command.Parameters.Add(Param);
                    }
                    int Result = Command.ExecuteNonQuery();
                    Parameters.Clear();
                    return Result;
                }
            }
        }

        protected DataTable ExecuteReader(string TransacSQL)
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                using (SqlCommand Command = new SqlCommand())
                {
                    Command.Connection = Connection;
                    Command.CommandText = TransacSQL;
                    Command.CommandType = CommandType.Text;
                    SqlDataReader Reader = Command.ExecuteReader();
                    using(var Data = new DataTable())
                    {
                        Data.Load(Reader);
                        Reader.Dispose();
                        return Data;
                    }
                }
            }
        }
    }
}
