using System;
using System.Linq;

namespace class_code
{
    class Program
    {
        // public static void PrintNumbers(int n)
        // {
        //     int length = (int)Math.Log10(n);
        //     int p = (int)Math.Pow(10, length);
        //     int k;
        //     while (n > 0)
        //     {
        //         k = n / p;
        //         n = n % p;
        //         p /= 10;
        //         Console.WriteLine(n % 10);
        //     }
        // }
        
        public static void Main(string[] args)
        {
            char c = '2';

            if (c >= '0' && c <= '9')
            {
                Console.WriteLine("number");
            } else if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("letter");
            }


            // int num = 1234567;
            // PrintNumbers(num);
            // Math.Pow(2, 3);
            // Math.Sqrt(10);
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // int i = 0;
            // while (i < 10)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            // int i = 11;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // } while (i < 10);

            // int a = 10;
            // int b = 50;
            // int res;
            // if (a > b)
            //     res = a + b;
            // else
            //     res = a * b;
            // res = (a > b) ? (a + b) : (a * b);
            // Console.WriteLine(res);

        }
    }
}

/*
int(4.67) -> 4
int(4.67 + 0.5) -> 5
*/