using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPassword
{
    public class EmailValidator
    {
        public static void Validate(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email cannot be null or empty.");
            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');
        
            if (atIndex < 3)
                throw new ArgumentException("Email must contain at least 3 characters before '@'.");
            if (dotIndex < atIndex +2)
                throw new ArgumentException("Email must contain at least 2 characters between '@' and the last '.'.");
            if (email.Length - dotIndex - 1 < 2)
                throw new ArgumentException("Email must contain at least 2 characters after the last '.'.");

        }
    }
}
