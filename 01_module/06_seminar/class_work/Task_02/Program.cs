using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] mas = new int[n];

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == null)
                    Console.Write("null ");
            }
            
            foreach (var el in mas)
            {
                Console.Write("{0} ", el);
            }
            
            Console.WriteLine(mas);

            string[] str = Console.ReadLine().Split();
            
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);
            Console.WriteLine();
        }
    }
}