using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("*Password should contain minimum 8 Characters");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validatePassword("shashank10@1997");
            Console.ReadKey();
        }
    }
}