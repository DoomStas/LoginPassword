using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPassword
{
    public static class EmailValidator
    {
        private const int MinNameLenght = 3;
        private const int MinDomahtLenght = 2;
        private const int MinZoneLenght = 2;
        public static void Validate(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email cannot be null or empty.");
            if (email.Contains(" "))
                throw new ArgumentException("Email must not contain spaces");

           string[] atParts = email.Split('@');
            if (atParts.Length != 2)
                throw new ArgumentException("Email must contain exactly one '@' symbol.");
            string namePart = atParts[0];
            string domainPart = atParts[1];

            if (namePart.Length < MinNameLenght)
                throw new ArgumentException($"Email name part must be at least {MinNameLenght} characters long.");

            string[] dotParts = domainPart.Split('.');
            if (dotParts.Length < 2)
                throw new ArgumentException("Email domain must contain a '.' symbol.");
            
            string domainName = dotParts[0];
            string domainZone = dotParts[^1];
            if (domainName.Length < MinDomahtLenght)
                throw new ArgumentException($"Email domain name must be at least {MinDomahtLenght} characters between '@' and '.'.");
            if (domainZone.Length < MinZoneLenght )
                throw new ArgumentException($"Email domain zone must be at least {MinZoneLenght} characters after the last '.'.");
  
        }

    }
}
