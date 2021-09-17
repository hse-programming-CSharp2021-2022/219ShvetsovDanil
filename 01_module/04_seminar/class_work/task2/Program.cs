using System;

namespace task2
{
    class Program
    {
        public static double Func(double x)
        {
            return x * x;
        }
        
        static void Main(string[] args)
        {
            double a, b, delta;
            do
            {
                Console.Write("Enter a value: ");
            } while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("Enter b value: ");
            } while (!double.TryParse(Console.ReadLine(), out b));
            
            do
            {
                Console.Write("Enter delta value: ");
            } while (!double.TryParse(Console.ReadLine(), out delta));

            double s = 0;
            while (a + delta <= b)
            {
                s += (delta * ((Func(a) + Func(a + delta)) / 2));
                a += delta;
            }

            a -= delta;
            Console.WriteLine($"square is {s + ((b - a) * ((Func(a) + Func(b)) / 2)):F3}");


        }
    }
}