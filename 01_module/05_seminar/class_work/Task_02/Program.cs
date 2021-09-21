using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 96;
            sbyte b = 112;
            sbyte c = 0;
            
            sbyte res1 = (sbyte)(a + b);
            sbyte res2 = unchecked ((sbyte)(96 + 112));
            sbyte res3 = (sbyte) (96 + 112 + c);
            
            Console.WriteLine(res1);
        }
    }
}