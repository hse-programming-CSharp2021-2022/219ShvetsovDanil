using System;

namespace Task_01
{
    class Program
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            while (number > 0)
            {
                sumOdd += number % 10;
                number /= 10;
                sumEven += number % 10;
                number /= 10;
            }
        }
        
        static void Main(string[] args)
        {
            uint number;
            uint.TryParse(Console.ReadLine(), out number);
            uint sumEven, sumOdd;
            Sums(number, out sumEven, out sumOdd);
            Console.WriteLine($"odd sum = {sumOdd}, even sum = {sumEven}");
        }
    }
}