using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex mc1 = new(4, 5);
            MyComplex mc2 = new(5, 6);
            
            Console.WriteLine(mc1 + mc2);
            Console.WriteLine(mc1 - mc2);
            Console.WriteLine(mc1 * mc2);
            Console.WriteLine(mc1 / mc2);
        }
    }
}