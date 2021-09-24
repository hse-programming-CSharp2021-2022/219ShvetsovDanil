using System;
/*
Info.
Discipline: "Programming".
Group: BPI219.
Student: Shvetsov Danil.
Date: 23.09.2021.
*/
namespace Task_02
{
    class Program
    {
        public static int Factorial(int x)
        {
            int result = 1;
            for (var i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

        public static double S1(double x)
        {
            int k = 2;
            double value1 = Math.Pow(x, k);
            double value2 = Math.Pow(x, k) - (Math.Pow(2, k + 1) * Math.Pow(x, k + 2) / Factorial(k + 2)) + 
                            (Math.Pow(2, k + 3) * Math.Pow(x, k + 4) / Factorial(k + 4));
            
            while (value1 != value2 && value1 != Double.NegativeInfinity && value2 != Double.NegativeInfinity &&
                   value1 != Double.PositiveInfinity && value2 != Double.PositiveInfinity)
            {
                value1 -= (Math.Pow(2, k + 1) * Math.Pow(x, k + 2) / Factorial(k + 2));
                value1 += (Math.Pow(2, k + 3) * Math.Pow(x, k + 4) / Factorial(k + 4));
                k++;
                value2 -= (Math.Pow(2, k + 1) * Math.Pow(x, k + 2) / Factorial(k + 2));
                value2 += (Math.Pow(2, k + 3) * Math.Pow(x, k + 4) / Factorial(k + 4));
            }

            return value1;
        }

        public static double S2(double x)
        {
            int k = 1;
            double value1 = 1;
            double value2 = 1 + x;

            while (value1 != value2 && value1 != Double.NegativeInfinity && value2 != Double.NegativeInfinity &&
                   value1 != Double.PositiveInfinity && value2 != Double.PositiveInfinity)
            {
                value1 += Math.Pow(x, k) / Factorial(k);
                k++;
                value2 += Math.Pow(x, k) / Factorial(k);
            }

            return value1;
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo keyToExit;
            do
            {
                // Input and parsing.
                double x;
                do
                {
                    Console.Write("Enter x value: ");
                } while (!double.TryParse(Console.ReadLine(), out x));

                // Output.
                Console.WriteLine($"S1 = {S1(x)}");
                Console.WriteLine($"S2 = {S2(x)}");
                
                Console.WriteLine("Press ENTER to exit.");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
                
            } while (keyToExit.Key != ConsoleKey.Enter);
        }
    }
}