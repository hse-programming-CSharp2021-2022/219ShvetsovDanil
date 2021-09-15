using System;
/* 1.1 Info
Discipline: "Programming"
Group: BPI219
Student: Shvetsov Danil
Date: 14.09.2021
*/
namespace Task_04
{
    class Program
    {
        public static string SymbolDefine(int code)
        {
            string result; // final string
            result = (code >= '0' && code <= '9') ? ($"It's a digit: {(char)code}")
                : ((code >= 'a' && code <= 'z' ? ($"It's a lowercase letter: {(char)code}") 
                : ((code >= 'A' && code <= 'Z' ? ($"It's an uppercase letter: {(char)code}") 
                : ($"Unknown symbol")))));
            return result;
        } // The end of SymbolDefine() method
        
        static void Main(string[] args)
        {
            // 1.2 Prolog
            int number; // input value of argument in integer type
            string res; // string for output with final result
            ConsoleKeyInfo keyToExit; // a key to press and exit the program
            
            do
            {
                // 2.1 Input
                do
                {
                    Console.Write("Enter value of argument: ");
                } while (!int.TryParse(Console.ReadLine(), out number));

                // 2.2 Output
                res = SymbolDefine(number);
                Console.WriteLine(res);
                
                // 1.3 Epilogue
                Console.WriteLine("Press ENTER to exit the program or another button to repeat:");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while (keyToExit.Key != ConsoleKey.Enter);
        } // The end of the Main() method
    }
}