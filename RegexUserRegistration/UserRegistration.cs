using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UserRegistration
    {
        public void validateMobileNo(string mobileNo)
        {
            string stringForMobileNo = "^[0-9]{1,3}[ ][6-9][0-9]{9}$";
            if (Regex.IsMatch(mobileNo, stringForMobileNo))
                Console.WriteLine(mobileNo + " is Valid");
            else
                Console.WriteLine(mobileNo + " is Invalid");
        }
    }

}