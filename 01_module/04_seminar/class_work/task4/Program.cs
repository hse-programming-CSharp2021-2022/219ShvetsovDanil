using System;

namespace task4
{
    class Program
    {
        public static int AkkermanFunc(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (m > 0 & n == 0)
                return AkkermanFunc(m - 1, 1);
            return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
        }
        
        static void Main(string[] args)
        {
            int m, n;
            
            do
            {
                Console.Write("Enter m value: ");
            } while (!int.TryParse(Console.ReadLine(), out m));
            
            do
            {
                Console.Write("Enter n value: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
            
            Console.WriteLine($"result of Akkerman function is {AkkermanFunc(m, n)}");
        }
    }
}