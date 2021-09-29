using System;

namespace Task_02
{
    class Program
    {
        public static void PrintArray(char[] mas)
        {
            foreach (char i in mas)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int k;
            do
            {
                Console.Write("Enter k value: ");
            } while (!int.TryParse(Console.ReadLine(), out k));

            char[] mas = new char[k];
            for (int i = 0; i < k; i++)
            {
                mas[i] = (char) rand.Next('A', 'Z' + 1);
            }

            PrintArray(mas);

            char[] masCopy = new char[k];
            Array.Copy(mas, masCopy, k);
            
            Array.Sort(masCopy);
            PrintArray(masCopy);
            
            Array.Reverse(masCopy);
            PrintArray(masCopy);
        }
    }
}