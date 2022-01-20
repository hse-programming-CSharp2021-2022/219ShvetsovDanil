using System;

namespace Task_01
{
    class Program
    {
        private static void PrintInfo(Dot A) => Console.WriteLine($"X: {A.X:F3}\nY: {A.Y:F3}\n");

        static void Main(string[] args)
        {
            Console.Write("Enter (x, y) coordinates: ");
            string[] input = Console.ReadLine()?.Split();
            var (x, y) = (double.Parse(input[0]), double.Parse(input[1]));

            Dot D = new(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }
    }
}