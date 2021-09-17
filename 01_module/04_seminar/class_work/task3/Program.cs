using System;

namespace task3
{
    class Program
    {
        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            return Factorial(n - 1) * n;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}