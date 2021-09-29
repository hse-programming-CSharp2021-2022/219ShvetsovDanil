using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            double angle,
                x,
                sin,
                sinOld,
                memb;
            ConsoleKeyInfo keyToExit;

            do
            {
                do
                {
                    Console.Write("Enter angle value: ");
                } while (!double.TryParse(Console.ReadLine(), out angle));

                x = angle % (2 * Math.PI);

                for (m = 1, sin = memb = x, sinOld = 0; sin != sinOld; m++)
                {
                    Console.WriteLine($"sin({x}) = {sin}\tmemb = {memb}");
                    sinOld = sin;
                    memb *= -x * x / 2 / m / (2 * m + 1);
                    sin += memb;
                }

                Console.WriteLine($"Sin({angle}) = {sin}");
                Console.WriteLine($"Math sin({angle}) = {Math.Sin(angle)}");
                Console.WriteLine("Press \"Enter\" to exit or another button to continue");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
                
            } while (keyToExit.Key != ConsoleKey.Enter);
        }
    }
}