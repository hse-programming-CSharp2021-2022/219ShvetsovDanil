using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 15.09.2021
*/
namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.2 Prolog
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // declaration of variables
                double userBudget; // a budget of user
                int budgetPercent; // a percent of user's budget
                double result; // a total sum in currency which user is ready to spend on computer games
                
                // 2.1 Input
                do
                {
                    Console.Write("Enter your total budget: ");
                } while (!double.TryParse(Console.ReadLine(), out userBudget));

                do
                {
                    Console.Write(
                        "Enter percent of your budget (0 - 100) you are ready to spend on computer games: ");
                } while (!int.TryParse(Console.ReadLine(), out budgetPercent));

                // 2.2 Processing
                if (userBudget < 0)
                    // 2.3 Output
                    Console.WriteLine("Incorrect budget! It can't be less than 0! Try again");
                else
                {
                    if (budgetPercent >= 0 & budgetPercent <= 100)
                    {
                        result = userBudget * budgetPercent / 100;
                        // 2.3 Output
                        Console.WriteLine($"Total sum you are ready to spend on computer games is {result:C3}");
                    }
                    else
                        // 2.3 Output
                        Console.WriteLine("You entered incorrect percent of your budget! Try again");
                }

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program / To repeat press another button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);

        } // The end of Main() method
    }
}