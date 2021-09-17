using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            float previousTotal = 0, currentTotal = ((float)1.0 / (a * b * c));
            while (previousTotal < currentTotal)
            {
                previousTotal = currentTotal;
                a++;
                b++;
                c++;
                currentTotal = ((float)1 / (a * b * c));
            }
            Console.WriteLine($"current total = {currentTotal}, previous total = {previousTotal}");

            int a1 = 1, b1 = 2, c1 = 3;
            double previousTotal1 = 0, currentTotal1 = (1.0 / (a1 * b1 * c1));
            while (previousTotal1 < currentTotal1)
            {
                previousTotal1 = currentTotal1;
                a1++;
                b1++;
                c1++;
                currentTotal1 = (1.0 / (a1 * b1 * c1));
            }
            Console.WriteLine($"current total = {currentTotal1}, previous total = {previousTotal}");
        }
    }
}