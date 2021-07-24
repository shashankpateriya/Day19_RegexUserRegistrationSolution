using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("First letter of last name should be capital.");
            Console.WriteLine("Length of last name should be minimum three characters.");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateLastName("Pateriya");
            Console.ReadKey();
        }
    }
}