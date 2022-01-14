using System;

namespace Task_05_1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            
            int[] arr = new int[10];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-15, 16);
            }
            
            Console.WriteLine("Initial array:");
            Array.ForEach(arr, el => Console.Write(el + "    "));
            Console.WriteLine();

            Console.WriteLine("Sorted array:");
            Array.Sort(arr, (x, y) => Math.Abs(x) > Math.Abs(y) ? 1 : -1 );
            Array.ForEach(arr, el => Console.Write(el + "    "));
        }
    }
}