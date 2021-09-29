using System;
// Номер 2 с массивами из классной работы.
namespace Task_01
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
        
        public static (int[] mas, int res1, int res2, int difference) GenerateArray(int[] mas)
        {
            int res1 = 0, res2 = 0;
            Random rand = new Random();
            
            for (int i = 0; i < mas.Length - 1; i++)
            {
                res2 ^= i + 1;
                while (true)
                {
                    var newNum = rand.Next(1, 101);
                    if (Array.IndexOf(mas, newNum) == -1)
                    {
                        mas[i] = newNum;
                        res1 ^= newNum;
                        break;
                    }
                }
            }

            res2 ^= 100;
            int difference = res1 ^ res2;
            while (true)
            {
                int oneMoreNumber = rand.Next(1, 101);
                if (oneMoreNumber != difference)
                {
                    mas[99] = oneMoreNumber;
                    res1 ^= oneMoreNumber;
                    break;
                }
            }
            
            return (mas, res1, res2, difference);
        }
        
        static void Main(string[] args)
        {
            int[] mas = new int[100];
            var res = GenerateArray(mas);
            PrintArray(mas);
            // Array.Sort(mas);
            // PrintArray(mas);
            // Console.WriteLine(res.Item4);
            Console.WriteLine(res.Item2 ^ res.Item4 ^ res.Item3);
        }
    }
}