using System;

namespace Task_01
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }

        public Human() { }
        public Human(string name) => Name = name;

        public override string ToString() => $"human {Name}";
    }
}