using System;
using System.Runtime.Serialization;

namespace Program
{
    public class AmountOfCreaturesException : ArgumentException
    {
        public AmountOfCreaturesException() { }
        
        public AmountOfCreaturesException(string message) : base(message) { }
        
        protected AmountOfCreaturesException(SerializationInfo info, StreamingContext streamingContext) : base(info, streamingContext) { }
    }
}