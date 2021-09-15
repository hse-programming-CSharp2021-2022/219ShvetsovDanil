using System;

namespace Task_01
{
    class Program
    {
        public static void MinMax(ref int a, out int minNumber, out int maxNumber)
        {
            int next;
            minNumber = 10;
            maxNumber = -1;
            while (a > 0)
            {
                next = a % 10;
                a /= 10;
                if (next < minNumber)
                    minNumber = next;
                if (next > maxNumber)
                    maxNumber = next;
            }
            
        }

        // public static void Add(int a)
        // {
        //     Console.WriteLine(a); // 10
        //     a += 10;
        //     Console.WriteLine(a); // 20
        // }
        //
        // public static void Add(ref int a)
        // {
        //     Console.WriteLine(a); // 10
        //     a += 10;
        //     Console.WriteLine(a); // 20
        // }
        //
        // ref out params передача значения по ссылке
        
        // public static void Add2(out int a)
        // {
        //     a = 10;
        //     Console.WriteLine(a); // 10
        //     a += 10;
        //     Console.WriteLine(a); // 20
        // }
        
        // out по выходу из метода переменной будет присвоено значение 
        // ref по входу в метод переменной должно быть присвоено значение

        // public static void Adder(out int res, params int[] arr)
        // {
        //     int sum = 0;
        //     for (int i = 0; i < arr.Length; i++)
        //         sum += arr[i];
        //     res = sum;
        // }
        //
        static void Main(string[] args)
        {
            // int min, max;
            // int a = 578204387;
            // Console.WriteLine(a);
            // MinMax(ref a, out min, out max);
            // Console.WriteLine(min);
            // Console.WriteLine(max);
            // Console.WriteLine(a);

            string s1 = "a";
            string s2 = "a";
            string s3 = Console.ReadLine();
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 == s3);
            
        }
    }
}