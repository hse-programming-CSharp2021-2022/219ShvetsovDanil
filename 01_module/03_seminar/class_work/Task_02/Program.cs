using System;

namespace Task_02
{
    class Program
    {
        public static bool Function1(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }

        public static void Function2(out bool result, bool p, bool q)
        {
            result = !(p & q) & !(p | !q);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Working with func1:");
            Console.WriteLine($"0 0 = {Function1(false, false)}");
            Console.WriteLine($"0 1 = {Function1(false, true)}");
            Console.WriteLine($"1 0 = {Function1(true, false)}");
            Console.WriteLine($"1 1 = {Function1(true, true)}");
            Console.WriteLine("Working with func2:");
            bool result;
            Function2(out result, false, false);
            Console.WriteLine(result);
            
        }
    }
}