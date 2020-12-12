using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Contracts;
using Common.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Common.Cache.Session;

namespace Domain.Models
{
    public class EmployeeModel
    {
        private string UsernameModel;
        private string DniModel;
        private string FirstNameModel;
        private string LastNameModel;
        private string EmailModel;
        private DateTime BirthdayModel;
        private string StateModel;
        private string PositionCodeModel;
        private string PositionModel;
        private int AgeModel;

        private IEmployeeRepository employeeRepository;
        public EntityState EState { private get; set; }
        private List<EmployeeModel> listEmployees;

        //PROPIEDADES/MODELO DE VISTA/ VALIDACIONES
        [Required]
        [RegularExpression("^([a-zA-Z ]+$)")]
        [StringLength(maximumLength: 255, MinimumLength = 3)]
        public string Username { get => UsernameModel; set => UsernameModel = value; }
        [Required]
        [RegularExpression("([0-9]+)")]
        [StringLength(maximumLength:8, MinimumLength = 8)]
        public string Dni { get => DniModel; set => DniModel = value; }
        public string FirstName { get => FirstNameModel; set => FirstNameModel = value; }
        public string LastName { get => LastNameModel; set => LastNameModel = value; }
        [EmailAddress]
        public string Email { get => EmailModel; set => EmailModel = value; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get => BirthdayModel; set => BirthdayModel = value; }
        public string State { get => StateModel; set => StateModel = value; }
        public string PositionCode { get => PositionCodeModel; set => PositionCodeModel = value; }
        public string Position { get => PositionModel; set => PositionModel = value; }
        public int Age { get => AgeModel; set => AgeModel = value; }

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
                employee.Username = Username;
                employee.Dni = Dni;
                employee.FirstName = FirstName;
                employee.LastName = LastName;
                employee.Email = Email;
                employee.Birthday = Birthday;
                employee.State = State;
                employee.PositionCode = PositionCode;

                switch (EState)
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
                        employeeRepository.Destroy(Username);
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
                    Username = employee.Username,
                    Dni = employee.Dni,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Email = employee.Email,
                    Birthday = employee.Birthday,
                    State = employee.State,
                    PositionCode = employee.PositionCode,
                    Position = employee.Position,
                    Age = CalculateAge(employee.Birthday)
                });
            }
            return listEmployees;
        }

        public bool Login(string username, string password)
        {
            return employeeRepository.Login(username, password);
        }

        //public IEnumerable<EmployeeModel> FindByNumber(string Filter)
        //{
        //    return All().FindAll(e => e.Number == Filter);
        //}

        public IEnumerable<EmployeeModel> Filter(string Filter)
        {
            return listEmployees.FindAll(e => e.FirstName.ToUpper().Contains(Filter.ToUpper()) | e.LastName.ToUpper().Contains(Filter.ToUpper()));
        }

        private int CalculateAge(DateTime Date)
        {
            DateTime DateNow = DateTime.Now;
            return DateNow.Year - Date.Year;
        }
    }
}
