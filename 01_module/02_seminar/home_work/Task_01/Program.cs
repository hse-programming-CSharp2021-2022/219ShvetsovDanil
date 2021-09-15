using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 14.09.2021
*/
namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.2 Prolog
            double x, // input variable
                a, // auxiliary variable
                b, // auxiliary variable
                res; // polynome result
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter x value: ");
                } while (!double.TryParse(Console.ReadLine(), out x));

                // 2.2 Processing
                a = x * x;
                b = x * 2;
                res = 3 * a * (b * (b + 1.5) - 1) + b - 4;

                // 2.3 Output
                Console.WriteLine($"The result of polynome is {res:F3}");
                
                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program / To repeat press another button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);

        } // The end of Main() method
    }
}