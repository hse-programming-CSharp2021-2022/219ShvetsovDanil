using System;
/* 1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 14.09.2021
*/
namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.2 Prolog
            double x, // coordinate of x
                y; // coordinate of y
            int radius; // radius of circle
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter x coordinate: ");
                } while (!double.TryParse(Console.ReadLine(), out x));

                do
                {
                    Console.Write("Enter y coordinate: ");
                } while (!double.TryParse(Console.ReadLine(), out y));

                radius = 10;

                // 2.2 Output
                if (x * x + y * y <= radius * radius)
                    Console.WriteLine("Point is inside the circle!");
                else
                    Console.WriteLine("Point is outside the circle!");

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program or another button to repeat");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);


        } // The end of Main() method
    }
}