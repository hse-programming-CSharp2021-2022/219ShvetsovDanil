using System;
/*
Info.
Discipline: "Programming".
Group: BPI219.
Student: Shvetsov Danil.
Date: 23.09.2021.
*/
namespace Task_01
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            // Right Shift in the alphabet.
            const int shift = 4;
            
            // Borders of Ascii table of lowercase letters.
            const int leftBorder = 97;
            const int rightBorder = 122;
            
            // Check on correctness of given letter.
            if (ch >= leftBorder && ch <= rightBorder)
            {
                ch = (char)((int)ch + shift);
                return true;
            }

            return false;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter your letter: ");
            
            // Input and parsing.
            string letterInput = Console.ReadLine();
            char ch;
            char.TryParse(letterInput, out ch);

            // Output.
            if (Shift(ref ch) == true)
            {
                Console.WriteLine($"Your input is correct. Letter after shift: \"{ch}\".");
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }
        }
    }
}