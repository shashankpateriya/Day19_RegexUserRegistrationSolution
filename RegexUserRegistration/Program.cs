﻿using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration!");

            //UserRegistration obj = new UserRegistration();
            //string FirstName, LastName, email, number, password;

            //Console.Write("Enter First Name: ");
            //FirstName = Console.ReadLine();
            //obj.ValidateFirstName(FirstName);

            //Console.Write("Enter Last Name: ");
            //LastName = Console.ReadLine();
            //obj.ValidateLastName(LastName);

            //Console.Write("Enter your email addresss: ");
            //email = Console.ReadLine();
            //obj.validateEmail(email);

            //Console.Write("Enter your mobile number: ");
            //number = Console.ReadLine();
            //obj.validatenumber(number);

            //Console.Write("Enter your password: ");
            //password = Console.ReadLine();
            //obj.validatePassword(password);

            UsingLambda obj = new UsingLambda();
            obj.validateRegex();
        }
    }

}