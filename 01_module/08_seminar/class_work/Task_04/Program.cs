using System;

namespace Task_04
{
    class Program
    {
        public static void PrintJaggedArray(int[][] jaggedArray)
        {
            foreach (var arr in jaggedArray)
            {
                foreach (var localEl in arr)
                {
                    Console.Write(localEl + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void ArrayReverseSort(int[][] jaggedArray)
        {
            for (var i = 0; i < jaggedArray.Length; i++)
            {
                Array.Sort(jaggedArray[i]);
                Array.Reverse(jaggedArray[i]);
            }
        }
        
        static void Main(string[] args)
        {
            int len;
            do
            {
                Console.Write("Enter length of jagged array: ");
            } while (!int.TryParse(Console.ReadLine(), out len));

            int[][] array = new int[len][];
            Random rand = new Random();
            
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new int[rand.Next(5, 16)];
                for (var j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(-10, 11);
                }
            }
            
            PrintJaggedArray(array);
            Console.WriteLine();
            
            ArrayReverseSort(array);
            PrintJaggedArray(array);
            
            Array.Sort(array, (x, y) => y.Length.CompareTo(x.Length));
            PrintJaggedArray(array);
        }
    }
}