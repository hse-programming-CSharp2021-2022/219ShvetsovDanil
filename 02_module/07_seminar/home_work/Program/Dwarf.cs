using System;

namespace Program
{
    public sealed class Dwarf : Creature
    {
        public Dwarf(string name, double speed, int strength) : base(name, speed)
        {
            Strength = strength;
        }

        private readonly int _strength;
        private int Strength
        {
            get => _strength;
            init
            {
                if (value is (>= 1 and <= 20))
                {
                    _strength = value;
                }
                else
                {
                    Random random = new Random();
                    _strength = random.Next(1, 21);
                }
            }
        }

        protected override string Run() => $"I am running with a speed of {Speed}. My strength is {Strength}";

        public static void MakeNewStaff() => Console.WriteLine("I've created a new staff!");
    }
}