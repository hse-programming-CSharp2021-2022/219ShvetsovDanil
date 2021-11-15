using System;
using System.Collections.Generic;

namespace Task_02
{
    class Program
    {
        private static void PrintArray(Cinderella[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintLentilList(List<Lentil> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
        
        private static void PrintAshesList(List<Ashes> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
        
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter n: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
            } while (true);

            Cinderella[] obj = { new Lentil(), new Ashes() };
            Cinderella[] array = new Cinderella[n];
            Random random = new();
            for (var i = 0; i < n; i++)
            {
                array[i] = obj[random.Next(0, 2)];
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Array");
            Console.ResetColor();
            PrintArray(array);
            List<Lentil> lentilsList = new();
            List<Ashes> ashesList = new();

            foreach (var item in array)
            {
                if (item is Lentil)
                {
                    lentilsList.Add((Lentil)item);
                }
                else if (item is Ashes)
                {
                    ashesList.Add((Ashes)item);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Lentils list");
            Console.ResetColor();
            PrintLentilList(lentilsList);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ashes list");
            Console.ResetColor();
            PrintAshesList(ashesList);
        }
    }
}