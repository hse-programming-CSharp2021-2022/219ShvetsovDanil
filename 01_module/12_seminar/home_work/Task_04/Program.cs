using System;
using System.Text.RegularExpressions;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            // Console.WriteLine("Initial text:");
            // Console.WriteLine(str);
            
            Console.WriteLine("New text:");
            Console.WriteLine(Regex.Replace(str, @"[уеыаоэёяию]", "*"));
        }
    }
}