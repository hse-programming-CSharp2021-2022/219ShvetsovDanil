using System;
using System.Linq;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersString = "1 2 3 4 5 6 7 8 9 10";
            var arrayWithNumbers = Array.ConvertAll(numbersString.Split(" "), int.Parse);
            var squaresOfNumbers = from num in arrayWithNumbers select num * num;

            foreach (var element in squaresOfNumbers)
            {
                Console.Write(element + " ");
            }
        }
    }
}