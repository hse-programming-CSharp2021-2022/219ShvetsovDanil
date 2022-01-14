using System;

namespace Task_03
{
    delegate double Sum(int n);
    
    class Program
    {
        static double Sum1(int n)
        {
            double total = 0;
            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < i; j++)
                {
                    
                    total += 1 / j;
                }
            }

            return total;
        }
        
        static double Sum2(int n)
        {
            double total = 0;
            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < i; j++)
                {
                    
                    total += 1 / Math.Pow(2, j);
                }
            }

            return total;
        }
        
        static void Main(string[] args)
        {
            Sum sum = Sum1;
            Console.WriteLine(sum(10));
            
            sum += Sum2;
            Console.WriteLine(sum(10));
        }
    }
}