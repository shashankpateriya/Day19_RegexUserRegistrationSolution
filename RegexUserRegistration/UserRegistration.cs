using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UserRegistration
    {
        public void validateEmail(string email)
        {
            string stringForEmail = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            if (Regex.IsMatch(email, stringForEmail))
                Console.WriteLine(email + " is Valid");
            else
                Console.WriteLine(email + " is Invalid");
        }
    }

}