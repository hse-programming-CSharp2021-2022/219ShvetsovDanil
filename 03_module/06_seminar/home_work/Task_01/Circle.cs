using System;

namespace Task_01
{
    internal class Circle : IComparable<Circle>
    {
        public Circle(double x, double y, double rad)
        {
            Center = new Point(x, y);
            Rad = rad;
        }
        
        public double Rad { get; init; }

        public readonly Point Center;
        public readonly Point InitialCoordinates = new(0, 0);

        public int CompareTo(Circle anotherCircle)
        {
            return Rad * Center.Distance(InitialCoordinates) >
                   anotherCircle.Rad * anotherCircle.Center.Distance(anotherCircle.InitialCoordinates)
                ? 1
                : -1;
        }

        public override string ToString() => $"Circle with radius: {Rad:F3}; center point: ({Center.X:F3}, {Center.Y:F3}); " +
                                             $"distance from (0, 0) to center: {Center.Distance(InitialCoordinates):F3}; " +
                                             $"product of radius distance from (0, 0) to center: {Rad * Center.Distance(InitialCoordinates):F3}";
    }
}