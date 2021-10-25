using System;
using System.Text.RegularExpressions;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var regIP = new Regex(@"(\b(([0-1]?\d\d?)|(2[0-4]\d)|(25[0-5]))\.){3}
                                          (([0-1]?\d\d?)|(2[0-4]\d)|(25[0-5]))\b");
            var s = "127.0.0.1 255.255.255.0  1300.6.7.8, 5.67.3.4 abc.def.gha.bcd.  1.1.1.1  10.10.10 10.10 10  " +
                    "10.10.10.a  10.10.10.256 222.222.5.999 5 ";

            foreach (var m in regIP.Matches(s))
            {
                Console.WriteLine(m);
            }
        }
    }
}