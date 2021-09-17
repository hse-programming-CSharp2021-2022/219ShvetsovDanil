using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 17.09.2021
*/
namespace Task_01
{
    class Program
    {
        public static bool G(double x, double y, int r)
        {
            if ((x <= 0) & (x * x + y * y <= r * r))
                return true;
            else if (((x >= 0 & x <= Math.Sqrt(r * r / 2.0)) & (y >= x) & (x * x + y * y <= r * r)))
                return true;
            return false;
        } // The end of method G() definition 
        
        
        static void Main(string[] args)
        {
            // 1.2 Prolog
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // declaration of variables
                double x, y; // coordinates on plane
                bool result; // boolean value of function G(x, y)
                int radius = 2; // radius of circle

                // 2.1 Input
                do
                {
                    Console.Write("Enter x coordinate: ");
                } while (!double.TryParse(Console.ReadLine(), out x));

                do
                {
                    Console.Write("Enter y coordinate: ");
                } while (!double.TryParse(Console.ReadLine(), out y));

                // 2.2 Processing
                result = G(x, y, radius);

                // 2.3 Output
                Console.WriteLine($"Is the point with coordinates x = {x}, y = {y} inside figure G? Answer: {result}");

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program or another button to repeat actions");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}