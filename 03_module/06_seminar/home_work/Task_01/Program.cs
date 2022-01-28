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
    
    class Program
    {
        private static readonly Random Random = new();

        // Sort with anonymous method.
        private static void AnonymousMethodSort(Circle[] circles)
        {
            Array.Sort(circles, delegate(Circle circle1, Circle circle2)
            {
                return circle1.Rad * circle1.Center.Distance(circle1.InitialCoordinates) >
                       circle2.Rad * circle2.Center.Distance(circle2.InitialCoordinates)
                    ? 1
                    : -1;
            });
        }

        // Sort with lambda-expression.
        private static void LambdaExpressionSort(Circle[] circles)
        {
            Array.Sort(circles, (circle1, circle2) 
                => circle1.Rad * circle1.Center.Distance(circle1.InitialCoordinates) > 
                   circle2.Rad * circle2.Center.Distance(circle2.InitialCoordinates) ? 1 : -1);
        }

        // Sort with IComparable interface.
        private static void InterfaceIComparableSort(Circle[] circles)
        {
            Array.Sort(circles);
        }
        
        static void Main(string[] args)
        {
            int amountCircles = Random.Next(3, 8);
            Circle[] circles = new Circle[amountCircles];

            for (var i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle(Random.Next(2, 21), Random.Next(2, 21), Random.Next(2, 11));
            }

            foreach (var circle in circles)
            {
                Console.WriteLine(circle);
            }
            Console.WriteLine("— — — — — — — — — — — — — — — — — — — — — —");
            
            SortChoose:
            Console.Write("Choose sort type (1 - anonymous method / 2 - lambda-expression / 3 - IComparable interface): ");
            string sortType = Console.ReadLine();
            switch (sortType)
            {
                case "1":
                    AnonymousMethodSort(circles);
                    break;
                case "2":
                    LambdaExpressionSort(circles);
                    break;
                case "3":
                    InterfaceIComparableSort(circles);
                    break;
                default:
                    Console.WriteLine("Incorrect sort type is chosen! Try again!");
                    goto SortChoose;
            }
            
            foreach (var circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}