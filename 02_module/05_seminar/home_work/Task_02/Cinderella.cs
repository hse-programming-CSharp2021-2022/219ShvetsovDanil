using System;

namespace Task_02
{
    public class Cinderella
    {
        protected readonly Random Random = new();
    }
    
    abstract class Something : Cinderella { }

    class Lentil : Something
    {
        private double Weight => Random.Next(0, 2) + Random.NextDouble();
        public override string ToString()
        {
            return $"Lentil\n{Weight:F3}\n";
        }
    }

    class Ashes : Something
    {
        private double Volume => Random.NextDouble();
        public override string ToString()
        {
            return $"Ashes\n{Volume:F3}\n";
        }
    }
}