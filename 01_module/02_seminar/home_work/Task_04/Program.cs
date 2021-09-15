using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 15.09.2021
*/
namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.2 Prolog
            int number; // input four-digits number from user
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter four-digits number: ");
                } while (!int.TryParse(Console.ReadLine(), out number));

                // 2.2 Processing
                if (number.ToString().Length == 4 & number > 0)
                {
                    while (number > 0)
                    {
                        // 2.3 Output
                        Console.Write($"{number % 10} ");
                        number /= 10;
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Incorrect format of input number! Remember: it should have four digits and be a natural one");
                
                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program / To repeat press another button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}