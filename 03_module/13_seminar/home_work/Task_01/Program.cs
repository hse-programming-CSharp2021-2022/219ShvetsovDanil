using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_01
{
    class Program
    {
        private static void SeparateLines()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("— — — — — — — — — — — — —");
            Console.ResetColor();
        }

        private static void GetElementsMNumber(out int m)
        {
            do
            {
                Console.Write("Введите число M элементов каждой последовательности: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out m))
                {
                    Console.WriteLine("Некорректное число M! Повторите ввод!");
                    continue;
                }
                
                break;
            } while (true);
        }

        private static void GetFibonacciNumbersCollection(int limit, out List<int> fibonacciCollection) 
            => fibonacciCollection = new Fibonacci().GetNextMember(limit).Cast<int>().ToList();

        private static void GetTriangleNumbersCollection(int limit, out List<double> triangleNumbersCollection)
            => triangleNumbersCollection = new TriangleNumbers().GetNextMember(limit).Cast<double>().ToList();

        private static void MergeTwoCollections(IEnumerator fibonacciCollection, IEnumerator triangleNumbersCollection, out List<double> mergedList)
        {
            mergedList = new List<double>();
            
            while (fibonacciCollection.MoveNext() && triangleNumbersCollection.MoveNext())
            {
                mergedList.Add((int)fibonacciCollection.Current + (double)triangleNumbersCollection.Current);
            }
        }

        private static void PrintCollectionElements<T>(List<T> collection) 
            where T: struct => collection.ForEach(el => Console.Write($"{el} "));
        
        static void Main(string[] args)
        {
            GetElementsMNumber(out int m);
            SeparateLines();
            
            Console.Write("Последовательность чисел ряда Фибоначчи: ");
            GetFibonacciNumbersCollection(m, out var fibonacciCollection);
            PrintCollectionElements(fibonacciCollection);

            Console.WriteLine();
            SeparateLines();
            
            Console.Write("Последовательность ряда треугольных чисел: ");
            GetTriangleNumbersCollection(m, out var triangleNumbersCollection);
            PrintCollectionElements(triangleNumbersCollection);
            
            Console.WriteLine();
            SeparateLines();
            
            Console.Write("Последовательность результата сложения чисел двух коллекций: ");
            MergeTwoCollections(fibonacciCollection.GetEnumerator(), triangleNumbersCollection.GetEnumerator(), out var mergedList);
            
            PrintCollectionElements(mergedList);
        }
    }
}