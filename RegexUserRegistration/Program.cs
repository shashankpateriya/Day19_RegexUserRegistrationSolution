using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("Email should have @");
            Console.WriteLine("Email should have a first name");
            Console.WriteLine("Email should have a domain name");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateEmail("shashank.pateriya4@gmail.co.in");
            Console.ReadKey();
        }
    }
}