using System;

namespace Task_02
{
    class Program
    {
        public static void MakingArrays(double[] array, ref int[] integerArray, ref double[] doubleArray)
        {
            for (var i = 0; i < array.Length; i++)
            {
                integerArray[i] = (int)array[i];
                doubleArray[i] = array[i] - (int)array[i];
            }
        }
        
        
        static void Main(string[] args)
        {
            int len;
            do
            {
                Console.Write("Enter array length: ");
            } while (!int.TryParse(Console.ReadLine(), out len));

            double[] array = new double[len];
            Random rand = new Random();
            
            for (var i = 0; i < len; i++)
            {
                array[i] = rand.Next(1, 101) + rand.NextDouble();
            }
            
            Array.ForEach(array, el => Console.Write(el + " "));
            Console.WriteLine();

            int[] integerArray = new int[len];
            double[] doubleArray = new double[len];

            MakingArrays(array, ref integerArray, ref doubleArray);
            Array.ForEach(integerArray, el => Console.Write(el + " "));
            Console.WriteLine();
            Array.ForEach(doubleArray, el => Console.Write(el + " "));
        }
    }
}