using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_05
{
    class Program
    {
        private static void PrintResult(IEnumerable<int> coll)
        {
            foreach (var el in coll)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] arrayIntegers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> squares = from el in arrayIntegers select el * el;
            PrintResult(squares);

            double[] arrayDoubles = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.65897, 7.2843 };
            IEnumerable<int> intParts = from el in arrayDoubles select (int) el;
            PrintResult(intParts);

            int[] arrayIntegers2 = { 12, 17, 58, 787, 33, 45, 107, 11, 28, 57 };
            IEnumerable<int> endsWith17 = from el in arrayIntegers2 where el % 10 == 7 select el;
            PrintResult(endsWith17);

            int[] arrayIntegers3 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            IEnumerable<int> lastDigit = from el in arrayIntegers3 select el % 10;
            PrintResult(lastDigit);
        }
    }
}