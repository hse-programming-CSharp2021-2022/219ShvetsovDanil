using System;

namespace Program
{
    public sealed class Elf : Creature
    {
        public Elf(string name, double speed) : base(name, speed)
        {
            _age = new Random().Next(100, 201);
        }

        private readonly int _age;

        protected override string Run()
        {
            const int crucialAge = 77;
            return $"I am running with a speed of {Speed + (int)(_age / crucialAge)}. My age is {_age}";
        }
    }
}