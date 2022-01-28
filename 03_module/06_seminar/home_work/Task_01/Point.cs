using System;

namespace Task_01
{
    internal class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public double Distance(Point point)
            => Math.Sqrt(Math.Pow(Math.Abs(X - point.X), 2) + Math.Pow(Math.Abs(Y - point.Y), 2));
    }
}