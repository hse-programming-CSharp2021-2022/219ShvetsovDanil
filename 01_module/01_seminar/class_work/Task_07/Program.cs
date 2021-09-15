using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt, secondInt;
            Console.Write("Целое число: ");
            string inputStr = Console.ReadLine();
            firstInt = int.Parse(inputStr);
            
            Console.Write("Целое число: ");
            string inputStr2 = Console.ReadLine();
            int.TryParse(inputStr2, out secondInt);
            
            Console.WriteLine("Ваш текст: " + (firstInt + secondInt));
        }
    }
}