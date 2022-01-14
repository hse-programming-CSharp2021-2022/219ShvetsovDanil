using System;

namespace Task_01
{
    // Initialising 2 delegates.
    public delegate int[] Row(int n);
    public delegate void Print(int[] arr);

    // Creating class with 2 static methods.
    class Task
    {
        public static int[] GetNumberDigits(int number) => Array.ConvertAll(number.ToString().ToCharArray(), input => Int32.Parse(input.ToString()));

        public static void PrintArray(int[] arr) => Array.ForEach(arr, digit => Console.Write(digit + " "));
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating number and array.
            var number = 12345;
            int[] arr = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            
            // Creating an instances of delegates.
            Row row = Task.GetNumberDigits;
            Print print = Task.PrintArray;

            // Check correctness of work (getting output).
            int[] digits = row(number);
            print(digits);
            Console.WriteLine();
            print(arr);
            Console.WriteLine();
            
            // Output of Method and Target for each delegate.
            Console.WriteLine(row.Method);
            Console.WriteLine(row.Target); // null cause method is static.
            Console.WriteLine();
            Console.WriteLine(print.Method);
            Console.WriteLine(print.Target); // null cause method is static.
        }
    }
}