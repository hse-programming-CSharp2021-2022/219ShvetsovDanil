using System;

namespace Task_01
{
    class Program
    {
        private static int ComparisonByGroups(Shape x, Shape y)
        {
            if (x is Sphere && y is Circle)
                return 1;
            if (x is Sphere && y is Cylinder)
                return 1;
            if (x is Sphere && y is Sphere)
                return 0;
            if (x is Cylinder && y is Circle)
                return 1;
            if (x is Cylinder && y is Cylinder)
                return 0;
            if (x is Circle && y is Circle)
                return 0;
            return -1;
        }
        
        private static void PrintFigures(Shape[] arrShape)
        {
            foreach (var shape in arrShape)
            {
                if (shape is Circle)
                {
                    Console.WriteLine("Circle");
                }
                else if (shape is Cylinder)
                {
                    Console.WriteLine("Cylinder");
                }
                else
                {
                    Console.WriteLine("Sphere");
                }
                
                Console.WriteLine(shape);
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Random random = new();
            var n1 = random.Next(3, 6);
            var n2 = random.Next(3, 6);
            var n3 = random.Next(3, 6);

            Shape[] arrShape = new Shape[n1 + n2 + n3];
            for (var i = 0; i < n1; i++)
            {
                arrShape[i] = new Circle(r: random.Next(1, 100) + random.NextDouble());
            }

            for (var i = n1; i < n1 + n2; i++)
            {
                arrShape[i] = new Cylinder(r: random.Next(1, 100) + random.NextDouble(),
                    h: random.Next(1, 100) + random.NextDouble());
            }

            for (var i = n2; i < n1 + n2 + n3; i++)
            {
                arrShape[i] = new Sphere(r: random.Next(1, 100) + random.NextDouble());
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not sorted!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintFigures(arrShape);
            Array.Sort(arrShape, ComparisonByGroups);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorted!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintFigures(arrShape);
        }
    }
}