using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BossAzConsole
{
    internal class Validation
    {
        private static readonly string _emailRegex = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
        private static readonly string _passRegex = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";

        public static bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, _emailRegex);
        }

        public static bool CheckPassword(string password)
        {
            return Regex.IsMatch(password, _passRegex);
        }

    }
}
