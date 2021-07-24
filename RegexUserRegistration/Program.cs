using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("MobileNo should start with country code");
            Console.WriteLine("follow by space and 10 digit number");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateMobileNo("91 7974146785");
            Console.ReadKey();
        }
    }
}