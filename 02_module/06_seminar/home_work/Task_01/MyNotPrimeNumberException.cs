using System;
using System.Runtime.Serialization;

namespace Task_01
{
    public class MyNotPrimeNumberException : Exception
    {
        public MyNotPrimeNumberException() { }
        
        public MyNotPrimeNumberException(string message) : base(message) { }
        
        public MyNotPrimeNumberException(string message, Exception innerException) : base(message, innerException) { }
        
        protected MyNotPrimeNumberException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public override string Message => "Number you entered is not prime!";
    }
}