using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 17.09.2021
*/
namespace Task_03
{
    class Program
    {
        public static double G(double x)
        {
            if (x <= 0.5)
                return Math.Sin(Math.PI / 2.0);
            return Math.Sin(((x - 1) * Math.PI) / 2.0);
        } // The end of G() method definition
        
        static void Main(string[] args)
        {
            // 1.1 Prolog
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // declaration of variables
                double x; // number x to get the method G() answer
                double result; // double result of method G()
                
                // 2.1 Input
                do
                {
                    Console.Write("Enter x value: ");
                } while (!double.TryParse(Console.ReadLine(), out x));
                
                // 2.2 Processing
                result = G(x);
                
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