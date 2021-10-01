using System;

namespace Task_01
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            foreach (var el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static int EvenSort(int a, int b)
        {
            if (a % 2 != 0 && b % 2 == 0)
                return 1;
            else if (a % 2 == 0 && b % 2 != 0)
                return -1;
            return 0;
        }

        public static int AmountDigitsSort(int a, int b)
        {
            if (a.ToString().Length < b.ToString().Length)
                return 1;
            else if (a.ToString().Length > b.ToString().Length)
                return -1;
            return 0;
        }

        public static int SumDigitsSort(int a, int b)
        {
            int totalA = 0, totalB = 0;
            
            while (a > 0)
            {
                totalA += a % 10;
                a /= 10;
            }

            while (b > 0)
            {
                totalB += b % 10;
                b /= 10;
            }

            if (totalA < totalB)
                return 1;
            else if (totalA > totalB)
                return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int len;
            do
            {
                Console.Write("Enter array length: ");
            } while (!int.TryParse(Console.ReadLine(), out len));

            Random rand = new Random();
            int[] array = new int[len];
            for (var i = 0; i < len; i++)
            {
                array[i] = rand.Next(0, 1001);
            }
            
            PrintArray(array);
            
            Array.Sort(array, EvenSort);
            PrintArray(array);
            
            Array.Sort(array, AmountDigitsSort);
            PrintArray(array);
            
            Array.Sort(array, SumDigitsSort);
            PrintArray(array);
            
        }
    }
}
