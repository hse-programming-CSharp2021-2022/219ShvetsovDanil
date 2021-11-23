using System;
using System.Runtime.Serialization;

namespace Program
{
    public class IncorrectCreatureNameException : ArgumentException
    {
        public IncorrectCreatureNameException() { }
    
        public IncorrectCreatureNameException(string message) : base(message) { }
    
        protected IncorrectCreatureNameException(SerializationInfo info, StreamingContext streamingContext) : base(info, streamingContext) { }
    }
}