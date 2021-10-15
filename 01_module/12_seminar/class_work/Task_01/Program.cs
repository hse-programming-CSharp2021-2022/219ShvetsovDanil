using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Anjfds", "idvndw", "Adchbsk", "ajkr", "vdf", "Agure"};
            
            List<string> selected = new List<string>();
            
            for (var i = 0; i < names.Length; i++)
            {
                if (names[i].ToUpper().StartsWith("A"))
                    selected.Add(names[i]);
            }
            
            var selected2 = from str in names
                where str.ToUpper().StartsWith("A") 
                // orderby str descending
                select str.ToArray();
            
            foreach (var i in selected2) 
            {
               Console.WriteLine(i); 
            } 
            Console.WriteLine();
            names[1] = "AAAA";
            foreach (var i in selected2) 
            {
                Console.WriteLine(i); 
            } 
            Console.WriteLine();
            
            var selected3 = names
                .Where(t => t.ToUpper().StartsWith("A"))
                .OrderByDescending(t => t)
                .ThenBy(t => t.Length);


            var s = "Бык тупогуб, тупогубенький бычок, у быка бела губа тупа.";
            Regex regex = new Regex(@"туп\w*");
            var matches = regex.Matches(s);

            foreach (var m in matches)
            {
                Console.WriteLine(m);
            }

            s = regex.Replace(s, "1111");
            Console.WriteLine(s);

            string s2 = "111-111-1111";
            Regex regex2 = new Regex(@"^\d{3}-\d{3}-\d{4}");
            Console.WriteLine(regex2.IsMatch(s2));
            Console.WriteLine(regex2.Match(s2));
        }
    }
}