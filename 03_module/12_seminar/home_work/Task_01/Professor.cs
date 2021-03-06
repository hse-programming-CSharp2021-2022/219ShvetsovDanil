using System;

namespace Task_01
{
    [Serializable]
    public class Professor : Human
    {
        public Professor() { }
        public Professor(string name) : base(name) { }

        public override string ToString() => $"professor {Name}";
    }
}