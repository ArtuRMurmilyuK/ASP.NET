using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;

namespace Timesheet.Api.Services
{
    public class AuthService
    {
        public AuthService()
        {
            Employees = new List<string>
            {
                "Иванов",
                "Петров",
                "Сидоров"
            };
        }
        public List<string> Employees { get; private set; }

        public bool Login(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }

            var isEmployeeExist = Employees.Contains(lastName);

            if (isEmployeeExist)
            {
                UserSession.Sessions.Add(lastName);
            }

            return isEmployeeExist;
        }
    }

    public static class UserSession
    {
        public static HashSet<string> Sessions { get; set; } = new HashSet<string>();
    }
}