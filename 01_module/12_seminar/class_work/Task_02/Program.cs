using System;
using System.Linq;

namespace Task_02
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        static int DigitsTotal(int num)
        {
            var total = 0;
            for (var i = 0; i < num.ToString().Length; i++)
            {
                total += num.ToString()[i];
            }

            return total;
        }

        static int TotalOfNumbers(int[] arr)
        {
            var total = 0;
            foreach (var el in arr)
            {
                total += el;
            }

            return total;
        }

        static int MinNum(int[] arr)
        {
            var minNum = arr[0];
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minNum)
                    minNum = arr[i];
            }

            return minNum;
        }

        static int MaxDigit(int el)
        {
            var maxDigit = 0;
            for (var i = 0; i < el.ToString().Length; i++)
            {
                if (el.ToString()[i] > maxDigit)
                    maxDigit = el.ToString()[i];
            }
            return maxDigit;
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter n number: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

            var array = new int[n];

            for (var i = 0; i < n; i++)
            {
                var rand = new Random();
                array[i] = rand.Next(1, 10001);
            }
            PrintArray(array);

            var req1 = from el in array
                where el.ToString().Length == 2 && el % 3 == 0
                select el;
            PrintArray(req1.ToArray());

            var req2 = array
                .Where(el => el.ToString() == el.ToString().Reverse().ToString())
                .OrderByDescending(el => el);
            PrintArray(req2.ToArray());

            var req3 = array
                .OrderBy(el => DigitsTotal(el))
                .ThenBy(el => el);
            PrintArray(req3.ToArray());

            var req4 = from el in array
                where el.ToString().Length == 4
                select el;
            Console.WriteLine(TotalOfNumbers(req4.ToArray()));

            var req5 = from el in array
                    where el.ToString().Length == 2
                    select el;
            Console.WriteLine(MinNum(req5.ToArray()));

            var req6 = from el in array
                select MaxDigit(el);
            PrintArray(req6.ToArray());
        }
    }
}