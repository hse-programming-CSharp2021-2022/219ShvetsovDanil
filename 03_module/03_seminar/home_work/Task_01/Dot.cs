using System;

namespace Task_01
{
    public delegate void CoordChanged(Dot dot);
    
    public class Dot
    {
        private readonly Random _random = new();
        
        public double X { get; private set; }
        public double Y { get; private set; }

        public Dot(double x, double y) => (X, Y) = (x, y);

        public event CoordChanged OnCoordChanged;

        public void DotFlow()
        {
            for (var i = 0; i < 10; i++)
            {
                X = _random.Next(-10, 11) + _random.NextDouble();
                Y = _random.Next(-10, 11) + _random.NextDouble();

                if (X < 0 && Y < 0)
                {
                    OnCoordChanged?.Invoke(this);
                }
            }
        }
    }
}