using System;

namespace Task_01
{
    class Point
    {
        // constructor with values
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        // default constructor
        public Point() : this (0, 0) { }

        // declaration of fields
        public double X { get; set; }
        public double Y { get; set; }

        // property Ro
        public double Ro => Math.Sqrt(X * X + Y * Y);
        
        // property Fi
        public double Fi
        {
            get
            {
                if (X > 0 && Y >= 0)
                    return Math.Atan(Y / X);
                if (X > 0 && Y < 0)
                    return Math.Atan(Y / X) + 2 * Math.PI;
                if (X < 0)
                    return Math.Atan(Y / X) + Math.PI;
                if (X == 0 && Y > 0)
                    return Math.PI / 2;
                if (X == 0 && Y < 0)
                    return (3 * Math.PI) / 2;
                return 0;
            }
        }

        // property PointData
        public string PointData => $"X = {X:F2}; Y = {Y:F2}; Ro = {Ro:F2}; Fi = {Fi:F2}";
    }
}