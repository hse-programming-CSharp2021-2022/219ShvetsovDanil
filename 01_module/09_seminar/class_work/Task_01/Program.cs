using System;
using System.Text;

namespace Task_01
{
    class Program
    {
        private static void Abbreviations(string str)
        {
            string[] separator = {";"};
            var array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            const string vowels = "eyuioaEYUIOA";

            foreach (var s in array)
            {
                var words = s.Split();
                var str1 = new StringBuilder("", 100);
                foreach (var word in words)
                {
                    for (var i = 0; i < word.Length; i++)
                    {
                        if (i == 0)
                            str1.Append(word.ToUpper()[i]);
                        else
                            str1.Append(word[i]);
                        if (vowels.Contains(word[i]))
                            break;
                    }
                }
                Console.WriteLine(str1);
            }
            
            
        }
        
        static void Main(string[] args)
        {
            var str = "Let it be; All you need is love; Dizzy Miss Lizzy";
            Abbreviations(str);
        }
    }
}