using System;
using System.Text;

namespace Task_02
{
    class Program
    {
        private static string ConvertHex2Bin(string hexNumber)
        {
            var totalStr = new StringBuilder();
            string[] s =
            {
                "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", 
                "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"
            };
            for (var i = 0; i < hexNumber.Length; i++)
            {
                if ("ABCDEF".Contains(hexNumber[i]))
                    totalStr.Append(s[10 + hexNumber[i] - 65]);
                else
                    totalStr.Append(s[hexNumber[i] - 48]);
            }
            
            return totalStr.ToString();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertHex2Bin("5A1"));
            Console.WriteLine(ConvertHex2Bin("FA1"));
            Console.WriteLine(ConvertHex2Bin("123"));
        }
    }
}