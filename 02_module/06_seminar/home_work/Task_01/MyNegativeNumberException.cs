using System;
using System.Runtime.Serialization;

namespace Task_01
{
    public class MyNegativeNumberException : Exception
    {
        public MyNegativeNumberException() { }
        
        public MyNegativeNumberException(string message) : base(message) { }

        public MyNegativeNumberException(string message, Exception innerException) : base(message, innerException) { }
        
        protected MyNegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override string Message => "Number you entered is negative!";
    }
}