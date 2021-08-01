using System;
using System.Collections.Generic;
using System.Text;

namespace RegexUserRegistration
{
    public class CustomException : Exception
    {
        private readonly ExceptionType type;

        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            INVALID_INPUT
        }


        public CustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}