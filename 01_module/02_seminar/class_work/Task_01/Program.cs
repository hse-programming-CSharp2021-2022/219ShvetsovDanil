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
        public static int CalculateBine(int n)
        {
            double b = (1 + Math.Sqrt(5)) / 2; // auxiliary variable having constant value
            double un = (Math.Pow(b, n) - (-Math.Pow(b, -n))) / (2 * b - 1); // double result of Bine
            return (int)un;
        } // The end of method CalculateBine() definition

        static void Main(string[] args)
        {
            // 1.2 Prolog
            int n = 1; // number of a row member
            int res; // integer result of un
            string line; // input line
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter a row member which you want to find: ");
                    line = Console.ReadLine();
                } while (!int.TryParse(line, out n));

                // 2.2 Processing
                if (n > 0)
                {
                    res = CalculateBine(n);
                    // 2.3 Output
                    Console.WriteLine($"The approximate result is {res}");
                }
                else
                    // 2.3 Output
                    Console.WriteLine("Incorrect input");
            } while (n > 0);
            
            // 1.3 Epilogue
            do
            {
                Console.WriteLine("Press ENTER to exit the program:");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        }
    }
}