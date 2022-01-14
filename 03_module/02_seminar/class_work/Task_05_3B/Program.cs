using System;

namespace Task_05_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            double[] arr = new double[10];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(random.Next(-4, 2) + random.NextDouble(), 2);
            }
            
            Console.WriteLine("Initial array:");
            Array.ForEach(arr, el => Console.Write(el + "    "));
            Console.WriteLine();
            
            Console.WriteLine("Sorted array:");
            int[] arr2 = Array.ConvertAll(arr, el => el >= 0 ? (int) el : 0);
            Array.ForEach(arr2, el => Console.Write(el + "    ")); 
        }
    }
}