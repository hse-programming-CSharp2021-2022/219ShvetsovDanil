using System;
using System.Runtime.Serialization;

namespace Program
{
    public class IncorrectCreatureSpeedException : ArgumentException
    {
        public IncorrectCreatureSpeedException() { }
    
        public IncorrectCreatureSpeedException(string message) : base(message) { }
    
        protected IncorrectCreatureSpeedException(SerializationInfo info, StreamingContext streamingContext) : base(info, streamingContext) { }
    }
}