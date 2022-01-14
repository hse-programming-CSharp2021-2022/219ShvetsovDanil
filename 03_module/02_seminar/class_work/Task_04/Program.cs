using System;
using System.Text;

namespace Task_04
{
    delegate string ConvertRule(string s);

    class Converter
    {
        public string Convert(string str, ConvertRule cr) => cr(str);
    }
    
    class Program
    {
        private static string RemoveDigits(string str)
        {
            StringBuilder outputStr = new();
            foreach (var el in str)
            {
                if (!"0123456789".Contains(el))
                {
                    outputStr.Append(el);
                }
            }

            return outputStr.ToString();
        }

        private static string RemoveSpaces(string str) => str.Replace(" ", "");
        
        static void Main(string[] args)
        {
            string[] strings =
            {
                "ck fwv rw 54; t3 5g534",
                "fkerj 5t v 43 354 36",
                "v tl354 g56 h3w",
                "f 45og3 65h  gwg5g556h354 "
            };

            ConvertRule cr1 = RemoveDigits;
            ConvertRule cr2 = RemoveSpaces;

            foreach (var s in strings)
            {
                Console.WriteLine(cr1?.Invoke(s));
            }
            Console.WriteLine();

            foreach (var s in strings)
            {
                Console.WriteLine(cr2?.Invoke(s));
            }
            Console.WriteLine();
            
            ConvertRule cr3 = RemoveSpaces;
            cr3 += RemoveDigits;
            
            foreach (var s in strings)
            {
                var outputStr = s;
                foreach (ConvertRule del in cr3.GetInvocationList())
                {
                    outputStr = del?.Invoke(outputStr);
                }
                Console.WriteLine(outputStr);
            }
            Console.WriteLine();
        }
    }
}