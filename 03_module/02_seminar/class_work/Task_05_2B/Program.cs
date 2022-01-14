using System;

namespace Task_05_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            
            int[] arr = new int[10];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 21);
            }
            
            Console.WriteLine("Initial array:");
            Array.ForEach(arr, el => Console.Write(el + "    "));
            Console.WriteLine();

            Console.WriteLine("Sorted array:");
            double[] arr2 = Array.ConvertAll(arr, (x) => 1.0 / x);
            Array.ForEach(arr2, el => Console.Write($"{el:F2}    "));
            Console.WriteLine();
        }
    }
}