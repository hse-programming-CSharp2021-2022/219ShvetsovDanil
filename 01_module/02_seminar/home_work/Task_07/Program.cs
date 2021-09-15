using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 15.09.2021
*/
namespace Task_07
{
    class Program
    {
        public static string PartsOfNumber(double num)
        {
            double fract; // fractional part of number
            int n; // integer part of number
            fract = num - (int)num;
            n = (int)num;
            return $"integer part = {n}, fractional part = {fract:F3}";
        } // The end of method PartsOfNumber() definition

        public static string SquareAndRoot(double num)
        {
            if (num >= 0)
                return $"square of {num} = {(num * num):F3}, root of {num} = {Math.Sqrt(num):F3}";
            else
                return $"square of {num} = {(num * num):F3}, root of {num} can't be defined, because {num} < 0";
        } // The end of method SquareAndRoot() definition
        
        static void Main(string[] args)
        {
            // 1.1 Prolog
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // declaration of variables
                double number; // a number from user
                string numberParts; // result string containing separate integer and fractional parts of number
                string squareAndRoot; // result string containing square and root of number
                // 2.1 Input
                do
                {
                    Console.Write("Enter fractional number: ");
                } while (!double.TryParse(Console.ReadLine(), out number));

                // 2.2 Processing
                numberParts = PartsOfNumber(number);
                squareAndRoot = SquareAndRoot(number);

                // 2.3 Output
                Console.WriteLine($"The parts of number are following: {numberParts}");
                Console.WriteLine($"Square and root values are following: {squareAndRoot}");

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program / To repeat press another button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}