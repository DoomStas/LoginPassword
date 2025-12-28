using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPassword
{
    public class PasswordValidator
    {
        public static void Validate(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty.");
            if (password.Contains(" "))
                throw new ArgumentException("Password must not contain spaces.");
            if (password.Length < 8)
                throw new ArgumentException("Password must be at least 8 characters long.");
            if (!password.Any(char.IsUpper))
                throw new ArgumentException("Password must contain at least one uppercase letter.");
            if (!password.Any(char.IsLower))
                throw new ArgumentException("Password must contain at least one lowercase letter.");
            if (!password.Any(char.IsDigit))
                throw new ArgumentException("Password must contain at least one digit.");
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                throw new ArgumentException("Password must contain at least one special character.");
        }
    }
}
