using System;

namespace loops
{
    class Program
    {

        public static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * i);
            }
            
            int n = 1;
            while (n < 11)
            {
                Console.WriteLine(n * n);
                n++;
            }

            int num = 1;
            do
            {
                Console.WriteLine(num * num);
                num++;
            } while (num < 11);

        }
    }
}