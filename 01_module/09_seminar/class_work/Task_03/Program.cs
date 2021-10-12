using System;
using System.Linq;

namespace Task_03
{
    class Program
    {
        static void Output(string[] array)
        {
            foreach (var word in array)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var result1 = input1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Output(result1);

            var input2 = Console.ReadLine();
            var result2 = input2.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(word => word.Length > 4).ToArray();
            Output(result2);

            // Сделал для английских букв, думаю, это не слишком важно.
            var input3 = Console.ReadLine();
            var result3 = input3.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => "eyuioa".Contains(word.ToLower()[0])).ToArray();
            Output(result3);
        }
    }
}