using System;
/*
Info.
Discipline: "Programming".
Group: BPI219.
Student: Shvetsov Danil.
Date: 23.09.2021.
*/
namespace Task_03
{
    class Program
    { 
        public static void NodAndNokResults(uint a, uint b, out uint nod, out uint nok)
        {
            uint num1 = a;
            uint num2 = b;
            uint tmpValue;
            while (b != 0)
            {
                tmpValue = b;
                b = a % b;
                a = tmpValue;
            }

            nod = a;
            nok = (num1 * num2) / nod;
        }
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyToExit;
            do
            {
                // Declaration and input.
                uint a, b;
                do
                {
                    Console.Write("Enter a value: ");
                } while (!uint.TryParse(Console.ReadLine(), out a));

                do
                {
                    Console.Write("Enter b value: ");
                } while (!uint.TryParse(Console.ReadLine(), out b));
                
                // Processing.
                NodAndNokResults(a, b, out uint nod, out uint nok);
                
                // Output.
                Console.WriteLine($"NOD = {nod}");
                Console.WriteLine($"NOK = {nok}");
                
                Console.WriteLine("To exit press ENTER.");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
                
            } while (keyToExit.Key != ConsoleKey.Enter);
        }
    }
}