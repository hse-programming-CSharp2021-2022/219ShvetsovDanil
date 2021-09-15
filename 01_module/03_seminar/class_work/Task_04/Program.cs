using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 10;
            // int b = 50;
            //
            // if (a > b)
            //     Console.WriteLine(a + b);
            // else if (a == b)
            //     Console.WriteLine(a * b);
            // else
            //     Console.WriteLine(a - b);

            int a = 3;
            switch (a)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("no");
                    break;
            }
            

        }
    }
}