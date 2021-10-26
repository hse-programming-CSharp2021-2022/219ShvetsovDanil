using System;
using System.Runtime.Intrinsics.X86;

namespace Task_01
{
    class Point2D // internal
    {
        // int x, y; // это поля класса, те данные, которые будут храниться внутри объекта

        // public int X
        // {
        //     get { return x; }
        //     set { x = value; }
        // }
        //
        // public int Y
        // {
        //     get { return y; } // ассесор доступа
        //     set { y = value; } // ассесор для записи = установки значения
        // }
        
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
        
        public static void PrintName() { Console.WriteLine("Point2D"); }

        public double Distance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double Distance(Point2D point)
        {
            return Math.Sqrt((X - point.X) * (X - point.X) + (Y - point.Y) * (Y - point.Y));
        }

        public static Point2D operator +(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.X + p2.X, p1.Y + p1.Y);
        }
        
        public static Point2D operator -(Point2D p1, Point2D p2)
        {
            return new Point2D(p1.X - p2.X, p1.Y - p2.Y);
        }

        public override string ToString()
        {
            return X + " " + Y;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D(5, 10);
            point1.X = 100;
            Point2D.PrintName();
            Console.WriteLine(point1.X);
            Console.WriteLine(point1.Y);
            Console.WriteLine(point1.Distance());

            Point2D point2 = new Point2D(20, 30);
            point2.X = 5;
            point2.Y = 10;
            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);
            Console.WriteLine(point2.Distance());
            Console.WriteLine(point1.Distance(point2));
            Console.WriteLine(point2.Distance(point1));
            
            Console.WriteLine(point2 + point1);
            Console.WriteLine(point2 - point1);
            
        }
    }
}