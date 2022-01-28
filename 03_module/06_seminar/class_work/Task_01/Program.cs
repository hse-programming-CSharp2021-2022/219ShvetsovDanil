using System;

namespace Task_01
{
    class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public static double GetDistance(Point a1, Point b1) => Math.Sqrt((a1.X * a1.X - b1.X * b1.X) + (a1.Y * a1.Y - b1.Y * b1.Y));
    }

    class TriangleComp
    {
        private Point[] _points;

        private double[] _sides;

        public TriangleComp(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            _points = new Point[] { new(x1, y1), new(x2, y2), new(x3, y3)};
            _sides = new[] { 
                Point.GetDistance(_points[0], _points[1]), 
                Point.GetDistance(_points[0], _points[2]),
                Point.GetDistance(_points[1], _points[2]) 
            };
        }
        
        public TriangleComp(Point a, Point b, Point c)
        {
            _points = new[] { a, b, c };
            _sides = new[] {
                Point.GetDistance(_points[0], _points[1]),
                Point.GetDistance(_points[0], _points[2]), 
                Point.GetDistance(_points[1], _points[2])
            };
        }

        public double Square
        {
            get
            {
                double p = (_sides[0] + _sides[1] + _sides[2]) / 2;
                return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
            }
        }
        
        public bool IsPointInsideTriangle(Point a)
        {
            var newTriangle = new TriangleComp(_points[0].X, _points[0].Y, _points[1].X, _points[1].Y, a.X, a.Y);
            return Square > newTriangle.Square; 
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var points = new Point[3];
            for (var i = 0; i < 3; i++)
            {
                Console.Write($"Enter {i + 1} point coords in (x, y) format: ");
                var input = Console.ReadLine()?.Split();
                points[i] = new Point(double.Parse(input[0]), double.Parse(input[1]));
            }
            var triangleComp = new TriangleComp(points[0], points[1], points[2]);
            
            Console.WriteLine(triangleComp.Square);
            Console.WriteLine(triangleComp.IsPointInsideTriangle(new Point(4, 2)));
        }
    }
}