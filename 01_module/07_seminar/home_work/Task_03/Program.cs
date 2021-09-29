using System;

namespace Task_03
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public static void ArrayCompression(ref int[] array)
        {
            int tmpVariable = 0;
            for (var i = 0; i < array.Length - 1 - tmpVariable; i++)
            {
                if ((array[i] + array[i + 1]) % 3 == 0)
                {
                    array[i] = array[i] * array[i + 1];
                    tmpVariable++;
                    
                    var j = 1;
                    while (i + j < array.Length - 1)
                    {
                        array[i + j] = array[i + j + 1];
                        j++;
                    }
                }
            }

            var endIndex = array.Length - tmpVariable;
            array = array[0..endIndex];
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[rand.Next(10, 20)];
            
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 50);
            }
            
            PrintArray(array);
            ArrayCompression(ref array);
            PrintArray(array);
        }
    }
}