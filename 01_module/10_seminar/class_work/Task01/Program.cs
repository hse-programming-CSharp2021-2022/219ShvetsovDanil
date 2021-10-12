using System;
using System.Text;

namespace Task01
{
    class Program
    {
        private static Random rnd = new();

        static char[] Series(int k, int ratio)
        {
            var arr = new char[k];
            
            var letterCount = (int)(k * ratio / 100.0);

            for (var i = 0; i < letterCount; i++)
            {
                arr[i] = (char) rnd.Next('a', 'z' + 1);
            }

            for (var i = letterCount; i < k; i++)
            {
                arr[i] = (char) rnd.Next('0', '9' + 1);
            }

            return arr;
        }

        static string Line(char[] series)
        {
            string[] letters = {"ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};

            var sb = new StringBuilder();

            for (var i = 0; i < series.Length; i++)
            {
                if (series[i] >= '0' && series[i] <= '9')
                {
                    var index = series[i] - '0';
                    sb.Append(letters[index] + " ");
                }
                else
                {
                    sb.Append(series[i] + " ");
                }
            }

            return sb.ToString();
        }
        
        static void Main(string[] args)
        {
            var n = 10;
            // процент букв
            var per = 30;

            var arr = Series(n, per);
            
            Array.ForEach(arr, x => Console.Write(x + " "));
            Console.WriteLine();
            var result = Line(arr);
            foreach (var el in result)
            {
                Console.Write(el);
            }
            Console.WriteLine(float.MaxValue);
        }
    }
}