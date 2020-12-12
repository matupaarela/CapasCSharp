using System;

namespace Common.Cache.Session
{
    public static class UserCache
    {
        public static string Username { get; set; }
        public static string Dni { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static DateTime Birthday { get; set; }
        public static string State { get; set; }
        public static string PositionCode { get; set; }
        public static string Position { get; set; }
    }
}
