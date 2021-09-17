using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 17.09.2021
*/
namespace Task_02
{
    class Program
    {
        public static double G(double x, double y)
        {
            if (x < y & x > 0)
                return x + Math.Sin(y);
            else if (x > y & x < 0)
                return y - Math.Cos(x);
            return 0.5 * x * y;
        } // the end of G() method definition
        
        static void Main(string[] args)
        {
            // 1.1 Prolog
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // declaration of variables
                double x, y; // numbers to get the method G() answer
                double result; // double result of method G()
                
                // 2.1 Input
                do
                {
                    Console.Write("Enter x value: ");
                } while (!double.TryParse(Console.ReadLine(), out x));
                
                do
                {
                    Console.Write("Enter y value: ");
                } while (!double.TryParse(Console.ReadLine(), out y));
                
                // 2.2 Processing
                result = G(x, y);
                
                // 2.3 Output
                Console.WriteLine($"The result of function G is {result:F3}");

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program or another button to repeat actions");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}