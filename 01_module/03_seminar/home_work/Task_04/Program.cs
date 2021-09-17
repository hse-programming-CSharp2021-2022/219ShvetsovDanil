using System;
/*
1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 17.09.2021
*/
namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1 Prolog
            ConsoleKeyInfo keyToExit; // a key to press and exit the program

            do
            {
                // declaration of variables
                int currentAudience; // audience entered by user
                int minAudience = 10000; // the smallest number of audience on the floor
                
                // 2.1 Input
                for (int i = 1; i < 4; i++)
                {
                    do
                    {
                        Console.Write($"Enter audience №{i}: ");
                    } while (!int.TryParse(Console.ReadLine(), out currentAudience) | currentAudience < 0);
                    
                    // 2.2 Processing 
                    if (currentAudience % 100 < minAudience)
                        minAudience = currentAudience % 100;
                }
                
                // 2.3 Output
                Console.WriteLine($"The smallest audience on the floor is {minAudience}");

                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program or another button to repeat actions");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of Main() method
    }
}