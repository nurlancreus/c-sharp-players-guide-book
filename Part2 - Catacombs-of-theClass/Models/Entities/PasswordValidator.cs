using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal static class PasswordValidator
    {
        public static bool IsPasswordValid(string password)
        {
            if (password.Length < 6 || password.Length > 13) return false;
            if (password.Contains('T') || password.Contains('&')) return false;

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch)) hasUpperCase = true;
                else if (char.IsLower(ch)) hasLowerCase = true;
                else if (char.IsDigit(ch)) hasDigit = true;

                if (hasUpperCase && hasLowerCase && hasDigit) return true;
            }

            return false;
        }

    }
}
