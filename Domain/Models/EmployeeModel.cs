using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Domain.Models
{
    public class EmployeeModel
    {
        private int ID;
        private string Number;
        private string Name;
        private string Email;
        private DateTime Birthday;
        private int Age;

        private IEmployeeRepository employeeRepository;
        public EntityState State { private get; set; }
        private List<EmployeeModel> listEmployees;

        //PROPIEDADES/MODELO DE VISTA/ VALIDACIONES
        public int id { get => ID; set => ID = value; }

        [Required]
        [RegularExpression("([0-9]+)")]
        [StringLength(maximumLength:8, MinimumLength = 8)]
        public string number { get => Number; set => Number = value; }

        [Required]
        [RegularExpression("^([a-zA-Z ]+$)")]
        [StringLength(maximumLength: 255, MinimumLength = 3)]
        public string name { get => Name; set => Name = value; }

        [EmailAddress]
        public string email { get => Email; set => Email = value; }

        public DateTime birthday { get => Birthday; set => Birthday = value; }
        public int age { get => Age; private set => Age = value; }

        public EmployeeModel()
        {
            employeeRepository = new EmployeeRepository();
        }

        public string SaveChanges()
        {
            string Msg = null;
            try
            {
                var employee = new Employee();
                employee.ID = ID;
                employee.Number = Number;
                employee.Name = Name;
                employee.Email = Email;
                employee.Birthday = Birthday;

                switch (State)
                {
                    case EntityState.Added:
                        //Ejecutar reglas comerciales / calculos
                        employeeRepository.Insert(employee);
                        Msg = "Guardado Correctamente";
                        break;
                    case EntityState.Modified:
                        employeeRepository.Update(employee);
                        Msg = "Modificado Correctamente";
                        break;
                    case EntityState.Deleted:
                        employeeRepository.Destroy(ID);
                        Msg = "Eliminado Correctamente";
                        break;
                }
            }catch(Exception Ex)
            {
                System.Data.SqlClient.SqlException SQLEx = Ex as System.Data.SqlClient.SqlException;
                if (SQLEx != null && SQLEx.Number == 2627) Msg = "Ya existe un registro con el mismo número de identidad";
                else Msg = Ex.ToString();
            }

            return Msg;
        }

        public List<EmployeeModel> All()
        {
            var employeeDataModel = employeeRepository.All();
            listEmployees = new List<EmployeeModel>();
            foreach(Employee employee in employeeDataModel)
            {
                listEmployees.Add(new EmployeeModel {
                    ID = employee.ID,
                    Number = employee.Number,
                    Name = employee.Name,
                    Email = employee.Email,
                    Birthday = employee.Birthday,
                    Age = CalculateAge(employee.Birthday)
                });
            }
            return listEmployees;
        }

        //public IEnumerable<EmployeeModel> FindByNumber(string Filter)
        //{
        //    return All().FindAll(e => e.Number == Filter);
        //}

        public IEnumerable<EmployeeModel> Filter(string Filter)
        {
            return listEmployees.FindAll(e => e.Number.Contains(Filter) || e.Name.Contains(Filter));
        }

        private int CalculateAge(DateTime Date)
        {
            DateTime DateNow = DateTime.Now;
            return DateNow.Year - Date.Year;
        }
    }
}
