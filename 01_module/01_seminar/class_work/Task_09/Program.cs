using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            
            Console.Write("Введите вещественное число: ");
            double.TryParse(Console.ReadLine(), out num1);
            
            Console.Write("Введите вещественное число: ");
            double.TryParse(Console.ReadLine(), out num2);
            
            Console.WriteLine(((num1 - (int)num1) + (num2 - (int)num2)).ToString("F3"));
            
        }
    }
}