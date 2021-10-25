using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var reg = new Regex(@"([01][0-9]|[2][123]):[0-5][\d]");
            var text = "Завтрак в 09:00. Обед в 37:98. 23:59";
            
            var time = new List<string>();
            for (var i = 0; i < 10; i++)
                for (var j = 0; j < 10; j++)
                    for (var k = 0; k < 10; k++)
                        for (var m = 0; m < 10; m++)
                            time.Add($"{i}{j}:{k}{m}");
            
            foreach (var t in time)
            {
                foreach (var m in reg.Matches(t))
                {
                    Console.WriteLine(m);
                }
            }
            
            
            // var timeSearch = reg.Matches(text);
            //
            // foreach (var match in timeSearch)
            // {
            //     Console.WriteLine(match);
            // }
        }
    }
}