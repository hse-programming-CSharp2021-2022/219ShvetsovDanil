using System;

namespace task6
{
    class Program
    {
        public static int AmountDel(int n)
        {
            int count = 0;
            for (int i = 1; i < n / 2 + 1; i++)
            {
                if (n % i == 0)
                    count++;
            }

            return count + 1;
        }
        
        
        static void Main(string[] args)
        {
            int k;
            
            do
            {
                Console.Write("Enter k value: ");
            } while (!int.TryParse(Console.ReadLine(), out k));

            for (int i = 100; i < 1000; i++)
            {
                if (AmountDel(i) == k)
                    Console.WriteLine(i);
            }
        }
    }
}