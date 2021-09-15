using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 15.09.2021
*/
namespace Task_05
{
    class Program
    {
        public static bool ExistenceOfTriangle(double a, double b, double c)
        {
            bool result; // return true or false according to possibility of existence of triangle
            result = (a + b > c) & (a + c > b) & (b + c > a);
            return result;
        } // the end of method ExistenceOfTriangle() definition

        static void Main(string[] args)
        {
            // 1.2 Prolog
            // three sides of triangle in double type
            double a,
                b,
                c;
            bool res; // possibility of existence 
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter side \"a\" of your triangle: ");
                } while (!double.TryParse(Console.ReadLine(), out a));

                do
                {
                    Console.Write("Enter side \"b\" of your triangle: ");
                } while (!double.TryParse(Console.ReadLine(), out b));

                do
                {
                    Console.Write("Enter side \"c\" of your triangle: ");
                } while (!double.TryParse(Console.ReadLine(), out c));

                // 2.2 Processing
                res = ExistenceOfTriangle(a, b, c);

                // 2.3 Output
                if (res == true)
                    Console.WriteLine($"Such triangle with sides \"{a} {b} {c}\" exists!");
                else
                    Console.WriteLine($"Such triangle with sides \"{a} {b} {c}\" doesn't exist!");

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program / To repeat press another button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}