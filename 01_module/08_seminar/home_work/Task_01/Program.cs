using System;

namespace Task_01
{
    class Program
    {
        private static void PrintMatrix(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++, Console.WriteLine())
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i, j]).ToString().PadRight(4));
                }
            }
                
        }

        static void Main(string[] args)
        {
            var number = 1;
            
            int n;
            do
            {
                Console.Write("Enter square matrix size: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
            
            var array = new int[n, n];
            int i = 0, j = -1;

            while (number < n * n)
            {
                while (j + 1 < n && array[i, j + 1] == 0)
                {
                    array[i, j + 1] = number;
                    number++;
                    j++;
                }
                
                // PrintMatrix(array);
                // Console.WriteLine();
                while (i + 1 < n && array[i + 1, j] == 0)
                {
                    array[i + 1, j] = number;
                    number++;
                    i++;
                }

                // PrintMatrix(array);
                // Console.WriteLine();
                while (j > 0 && array[i, j - 1] == 0)
                {
                    array[i, j - 1] = number;
                    number++;
                    j--;
                }

                // PrintMatrix(array);
                // Console.WriteLine();
                while (i > 0 && array[i - 1, j] == 0)
                {
                    array[i - 1, j] = number;
                    number++;
                    i--;
                }
                // PrintMatrix(array);
                // Console.WriteLine();
            }

            PrintMatrix(array);
        }
    }
}