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
        public static string DigitsSort(int f, int s, int th)
        {
            // auxiliary variables
            int mx, mn, avrg;
            mn = (f < s) ? (f < th ? f : th) : (s < th ? s : th);
            mx = (f > s) ? (f > th ? f : th) : (s > th ? s : th);
            avrg = f + s + th - (mx + mn);
            return $"{mx}{avrg}{mn}";
        } // The end of DigitsSort() method definition
        
        static void Main(string[] args)
        {
            // 1.2 Prolog
            int number, // input number
                firstDigit, // first digit of number
                secondDigit, // second digit of number
                thirdDigit; // third digit of number
            string res; // result containing max number from digits
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter number: ");
                } while (!int.TryParse(Console.ReadLine(), out number));

                // 2.2 Processing
                if (number.ToString().Length == 3)
                {
                    firstDigit = number / 100;
                    secondDigit = number / 10 % 10;
                    thirdDigit = number % 10;
                    res = DigitsSort(firstDigit, secondDigit, thirdDigit);

                    // 2.3 Output
                    Console.WriteLine($"Max number from digits is {res}");
                }
                else 
                    Console.WriteLine("Incorrect format of number!");

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program / To repeat press another button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);

        } // The end of Main() method
    }
}