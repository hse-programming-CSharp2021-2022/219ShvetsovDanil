using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 / 3 = " + (2 / 3).ToString("D"));
            Console.WriteLine("2.0 / 3 = " + (2.0 / 3).ToString("F4"));
            Console.WriteLine("Для завершения нажмите Enter");
            Console.ReadLine();
        }
    }
}