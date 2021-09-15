using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 15.09.2021
*/
namespace Task_03
{
    class Program
    {
        public static string RootsOfQuadraticEquation(double a, double b, double c)
        {
            double x1, x2; // root of quadratic equation
            string y1, y2; // roots for complex results
            string result; // result of everything
            double d; // a discriminant
            d = (b * b) - (4 * a * c);
            switch (d)
            {
                case > 0:
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    result = $"x1 = {x1:F3}, x2 = {x2:F3}";
                    return result;
                case 0:
                    x1 = (-b) / (2 * a);
                    result = $"x = {x1:F3}";
                    return result;
                case < 0:
                    x1 = (-b) / (2 * a);
                    x2 = (-d) / (2 * a);
                    y1 = $"{x1:F3} - {x2:F3}i";
                    y2 = $"{x1:F3} + {x2:F3}i";
                    result = $"x1 = {y1}, x2 = {y2}";
                    return result;
                default:
                    return "An error occured";
            }
        } // The end of method RootsOfQuadraticEquation() definition
        
        
        static void Main(string[] args)
        {
            // 1.2 Prolog
            // the coefficients of quadratic equation
            double a,
                b,
                c;
            string res; // roots
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter coefficient \"a\" not equal to 0: ");
                } while (!double.TryParse(Console.ReadLine(), out a));

                do
                {
                    Console.Write("Enter coefficient \"b\" not equal to 0: ");
                } while (!double.TryParse(Console.ReadLine(), out b));

                do
                {
                    Console.Write("Enter coefficient \"c\" not equal to 0: ");
                } while (!double.TryParse(Console.ReadLine(), out c));

                // 2.2 Processing
                if (a != 0 & b != 0 & c != 0)
                {
                    res = RootsOfQuadraticEquation(a, b, c);
                    // 2.3 Output
                    Console.WriteLine($"Result of quadratic equation is following: {res}");
                }
                else
                    // 2.3 Output
                    Console.WriteLine("Incorrect input");
                
                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program / To repeat press another button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}