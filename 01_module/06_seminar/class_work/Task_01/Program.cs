using System;

namespace Task_01
{
    class Program
    {
        public static void Transform(int n)
        {
            for (int i = 9; i >= 0; i--)
            {
                int num = n;
                while (num > 0)
                {
                    if ((num % 10) == i)
                        Console.Write(i);
                    num /= 10;
                }
            }
        }
        
        static void Main(string[] args)
        {
            int number;
            int.TryParse(Console.ReadLine(), out number);
            Transform(number);
        }
    }
}