using System;

namespace Task_03
{
    class Program
    {
        public static void PrintArray(int[] mas)
        {
            foreach (int el in mas)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        public static int Total(int[] mas)
        {
            int total = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                total += mas[i];
            }

            return total;
        }

        public static int[] GenerateArray(int[] mas)
        {
            Random rand = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                while (true)
                {
                    var newNum = rand.Next(1, 101);
                    if (Array.IndexOf(mas, newNum) == -1)
                    {
                        mas[i] = newNum;
                        break;
                    }
                }
            }

            return mas;
        }

        // public static int Check(int[] mas)
        // {
        //     int res = -1;
        //     for (int i = 0; i < mas.Length - 1; i++)
        //     {
        //         if (mas[i + 1] - mas[i] > 1)
        //             res = (mas[i] + mas[i + 1]) / 2;
        //     }
        //
        //     return res;
        // }
        
        static void Main(string[] args)
        {
            int[] mas = new int[99];
            GenerateArray(mas);
            PrintArray(mas);
            Console.WriteLine();
            // Array.Sort(mas);
            // PrintArray(mas);
            // int res = Check(mas);
            Console.WriteLine(5050 - Total(mas));
        }
    }
}