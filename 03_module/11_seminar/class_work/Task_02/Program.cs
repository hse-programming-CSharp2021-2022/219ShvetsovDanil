using System;
using System.IO;

namespace Task_02
{
    class Program
    {
        private static readonly Random Random = new();
        
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter(File.Open("task_2.txt", FileMode.Create, FileAccess.Write)))
            {
                for (var i = 0; i < 10; i++)
                {
                    sw.Write((char) Random.Next(1, 101));
                }
            }

            int[] array = new int[10];
            using (var sr = new StreamReader(File.Open("task_2.txt", FileMode.Open, FileAccess.Read)))
            {
                for (var i = 0; i < 10; i++)
                {
                    array[i] = sr.Read();
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
                
                int.TryParse(Console.ReadLine(), out var n);
                var min = 1000;
                var index = 0;
                
                for (var i = 0; i < 10; i++)
                {
                    if (Math.Abs(n - array[i]) < min)
                    {
                        min = Math.Abs(n - array[i]);
                        index = i;
                    }
                }
                array[index] = n;
            }

            using (var sw = new StreamWriter(File.Open("task_2.txt", FileMode.Open, FileAccess.Write)))
            {
                for (var i = 0; i < 10; i++)
                {
                    sw.Write((char) array[i]);
                }
            }
            
            using (var sr = new StreamReader(File.Open("task_2.txt", FileMode.Open, FileAccess.Read)))
            {
                for (var i = 0; i < 10; i++)
                {
                    array[i] = sr.Read();
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}