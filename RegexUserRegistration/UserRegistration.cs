using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UserRegistration
    {
        public void validatePassword(string password)
        {
            string stringForPassword = "^.{8,}?";
            if (Regex.IsMatch(password, stringForPassword))
                Console.WriteLine(password + " is Valid");
            else
                Console.WriteLine(password + " is Invalid");
        }
    }
}