using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 14.09.2021 
*/
namespace Task_02
{
    class Program
    {
        public static double CalculatingSquare(double r)
        {
            return (Math.PI * r * r);
        } // The end of method CalculatingSquare() definition

        public static double CalculatingLength(double r)
        {
            return (2 * Math.PI * r);
        } // The end of method CalculatingLength() definition
        
        static void Main(string[] args)
        {
            // 1.1 Prolog
            double radius, // input radius of circle modified to double value
                square, // calculated square of circle
                length; // calculated length of cirle
            string line; // input line
            ConsoleKeyInfo keyToExit; // a key to press and exit the program
            
            do {
                // 2.1 Input
                do
                {
                    Console.Write("Enter radius value: ");
                    line = Console.ReadLine();
                } while (!double.TryParse(line, out radius));
            
                // 2.2 Processing
                if (radius > 0)
                {
                    square = CalculatingSquare(radius);
                    length = CalculatingLength(radius);
                    // 2.3 Output
                    Console.WriteLine($"The value of square is {square:F3}");
                    Console.WriteLine($"The value of length is {length:F3}");
                }
                else
                    // 2.3 Output
                    Console.WriteLine("Incorrect input");
            } while (radius > 0);
            
            // 1.3 Epilogue
            do
            {
                Console.WriteLine("Press ENTER to exit the program");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);

        } // The end of Main() method
    }
}