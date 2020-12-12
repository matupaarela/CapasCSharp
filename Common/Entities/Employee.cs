using System;

namespace Common.Entities
{
    public class Employee
    {
        public string Username { get; set; }
        public string Dni { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string State { get; set; }
        public string PositionCode { get; set; }
        public string Position { get; set; }
    }
}
