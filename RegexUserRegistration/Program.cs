using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("First letter of name should be capital.");
            Console.WriteLine("Length of name should be minimum three characters.");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateFirstName("Shashank");
            Console.ReadKey();
        }
    }
}