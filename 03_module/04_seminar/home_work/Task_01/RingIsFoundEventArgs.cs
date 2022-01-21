using System;

namespace Task_01
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) => Message = s;

        public string Message { get; set; }
    }
}