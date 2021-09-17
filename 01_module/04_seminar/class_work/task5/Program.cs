using System;

namespace task5
{
    class Program
    {
        public static double TotalNoRec(double k, double r, uint n)
        {
            for (int i = 0; i < n; i++)
                k *= 1.0 + r;
            
            return k;
        }

        public static double TotalRec(double k, double r, uint n)
        {
            if (n == 1)
                return k * (1.0 + r);
            return TotalRec(k * (1.0 + r), r, n - 1);
        }
        
        
        static void Main(string[] args)
        {
            double k, r;
            uint n;

            do
            {
                Console.Write("Enter k: ");
            } while (!double.TryParse(Console.ReadLine(), out k));
            
            do
            {
                Console.Write("Enter r: ");
            } while (!double.TryParse(Console.ReadLine(), out r));
            
            do
            {
                Console.Write("Enter n: ");
            } while (!uint.TryParse(Console.ReadLine(), out n));
            
            Console.WriteLine(TotalNoRec(k, r, n));
            Console.WriteLine(TotalRec(k, r, n));
        }
    }
}