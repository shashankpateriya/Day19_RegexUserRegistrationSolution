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

            validateUser.validateEmail("abc@yahoo.com");
            validateUser.validateEmail("abc-100@yahoo.com");
            validateUser.validateEmail("abc.100@yahoo.com");
            validateUser.validateEmail("abc111@abc.com");
            validateUser.validateEmail("abc-100@abc.net");
            validateUser.validateEmail("abc-100@abc.com.au");
            validateUser.validateEmail("abc@1.com");
            validateUser.validateEmail("abc@gmail.com.com");
            validateUser.validateEmail("abc+100@gmail.com");
            Console.ReadKey();
        }
    }
}