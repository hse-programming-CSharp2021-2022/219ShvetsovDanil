using System;
using System.Formats.Asn1;

/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 14.09.2021
*/
namespace Task_03
{
    class Program
    {
        public static string ValuesSort(int x, int y, int z)
        {
            int a1, a2, a3; // auxiliary variables
            a1 = (x > y) ? (x > z ? x : z) : (y > z ? y : z);
            a2 = (x < y) ? (x < z ? x : z) : (y < z ? y : z);
            a3 = x + y + z - (a1 + a2);
            return $"New values: x = {a2}, y = {a3}, z = {a1}";
        } // The end of method ValuesSort definition

        static void Main(string[] args)
        {
            // 1.2 Prolog
            int x, // input of first variable
                y, // input of second variable
                z; // input of third variable
            string xString, yString, zString; // input strings
            string result; // result string with x <= y <= z values
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter x value: ");
                    xString = Console.ReadLine();
                } while (!int.TryParse(xString, out x));

                do
                {
                    Console.Write("Enter y value: ");
                    yString = Console.ReadLine();
                } while (!int.TryParse(yString, out y));

                do
                {
                    Console.Write("Enter z value: ");
                    zString = Console.ReadLine();
                } while (!int.TryParse(zString, out z));

                // 2.2 Output
                result = ValuesSort(x, y, z);
                Console.WriteLine(result);
                
                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program:");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}