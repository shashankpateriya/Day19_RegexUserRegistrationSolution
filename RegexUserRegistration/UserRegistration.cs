using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UserRegistration
    {
        public void validateFirstName(string firstName)
        {
            string stringForFirstName = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(firstName, stringForFirstName))
                Console.WriteLine(firstName + " is Valid");
            else
                Console.WriteLine(firstName + " is Invalid");
        }
    }
}