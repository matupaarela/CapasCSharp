﻿using System;
using System.Collections.Generic;
using DataAccess.Contracts;
using Common.Entities;
using System.Data;
using System.Data.SqlClient;
using Common.Cache.Session;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : MasterRepository, IEmployeeRepository
    {
        //Campos
        private string TSAll, TSInsert, TSUpdate, TSDestroy,TSLogin;
        //Prpiedades

        //Constructores
        public EmployeeRepository()
        {
            TSAll = "sfe_employee_all";
            TSInsert = "sfe_employee_insert";
            TSUpdate = "sfe_employee_update";
            TSDestroy = "sfe_employee_delete";
            TSLogin = "sfe_login";
        }

        //Métodos o COmportamiento del Objeto
        public IEnumerable<Employee> All()
        {
            var TableResult = ExecuteReader(TSAll);
            var ListEmployee = new List<Employee>();
            foreach(DataRow Row in TableResult.Rows)
            {
                ListEmployee.Add(new Employee {
                    Username = Convert.ToString(Row["username"]),
                    Dni = Convert.ToString(Row["dni"]),
                    FirstName = Convert.ToString(Row["first_name"]),
                    LastName = Convert.ToString(Row["last_name"]),
                    Email = Convert.ToString(Row["email"]),
                    Birthday = Convert.ToDateTime(Row["birthday"]),
                    State = Convert.ToString(Row["state"]),
                    PositionCode = Convert.ToString(Row["position_code"]),
                    Position = Convert.ToString(Row["position"])
                });
            }
            return ListEmployee;
        }

        public int Insert(Employee employee)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@username", employee.Username));
            Parameters.Add(new SqlParameter("@dni", employee.Dni));
            Parameters.Add(new SqlParameter("@first_name", employee.FirstName));
            Parameters.Add(new SqlParameter("@last_name", employee.LastName));
            Parameters.Add(new SqlParameter("@mail", employee.Email));
            Parameters.Add(new SqlParameter("@birthday", employee.Birthday));
            Parameters.Add(new SqlParameter("@state", employee.State));
            Parameters.Add(new SqlParameter("@position_code", employee.PositionCode));
            return ExecuteNonQuery(TSInsert);
        }

        public int Update(Employee employee)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@username", employee.Username));
            Parameters.Add(new SqlParameter("@dni", employee.Dni));
            Parameters.Add(new SqlParameter("@first_name", employee.FirstName));
            Parameters.Add(new SqlParameter("@last_name", employee.LastName));
            Parameters.Add(new SqlParameter("@mail", employee.Email));
            Parameters.Add(new SqlParameter("@birthday", employee.Birthday));
            Parameters.Add(new SqlParameter("@state", employee.State));
            return ExecuteNonQuery(TSUpdate);
        }

        public int Destroy(int id)
        {
            throw new NotFiniteNumberException();
        }

        public int Destroy(string code)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@code", code));
            return ExecuteNonQuery(TSDestroy);
        }

        public bool Login(string username, string password)
        {
            Parameters = new List<SqlParameter>();
            Parameters.Add(new SqlParameter("@username", username));
            Parameters.Add(new SqlParameter("@password", password));
            var Data = ExecuteParamReader(TSLogin);
            if (Data.Rows.Count > 0)
            {
                Employee employee = new Employee() {
                    Username = Convert.ToString(Data.Columns["username"]),
                    Dni = Convert.ToString(Data.Columns["dni"]),
                    FirstName = Convert.ToString(Data.Columns["first_name"]),
                    LastName = Convert.ToString(Data.Columns["last_name"]),
                    Email = Convert.ToString(Data.Columns["email"]),
                    Birthday = Convert.ToDateTime(Data.Columns["birthday"]),
                    State = Convert.ToString(Data.Columns["state"]),
                    PositionCode = Convert.ToString(Data.Columns["position_code"]),
                    Position = Convert.ToString(Data.Columns["position"]),
            };
                return true;
            }
            return false;
        }
    }
}
