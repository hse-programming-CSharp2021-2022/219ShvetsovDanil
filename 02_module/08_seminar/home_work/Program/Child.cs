using System;

namespace Program
{
    class Child : Person
    {
        public string AdditionalPocket { get; set; }
        public Child(string name) : base(name)
        {
            AdditionalPocket = string.Empty;
        }
        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else if (AdditionalPocket.Equals(string.Empty))
                AdditionalPocket = present;
            else
                throw new ArgumentException(">2 gifts");
        }
        public override string ToString()
        {
            return base.ToString() + $"AdditionalPocket = {AdditionalPocket}";
        }
    }
}