using System;

namespace Program
{
    public class Creature
    {
        public Creature(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }
        
        private readonly string _name;
        private string Name
        {
            get => _name;
            init
            {
                const int leftUpperAsciiBorder = 65;
                const int rightUpperAsciiBorder = 90;
                if ((int) value[0] is (>= leftUpperAsciiBorder and <= rightUpperAsciiBorder))
                {
                    _name = value;
                }
                else
                {
                    throw new IncorrectCreatureNameException("Incorrect creature name!");
                }
            }
        }

        private readonly double _speed;
        protected double Speed
        {
            get => _speed;
            private init
            {
                if (value >= 0)
                {
                    _speed = value;
                }
                else
                {
                    throw new IncorrectCreatureSpeedException("Incorrect creature speed!");
                }
            }
        }

        protected virtual string Run() => $"I'm running with a speed of {Speed}";

        public override string ToString()
        {
            return $"{Run()}. My name is {Name}.";
        }
    }
}