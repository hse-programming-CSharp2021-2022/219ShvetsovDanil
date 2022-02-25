using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_01
{
    class Program
    {
        private static void GetNumberOfCollection(out int n)
        {
            do
            {
                Console.Write("Enter amount of numbers in collection: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("Incorrect input! Try again!");
                    continue;
                }
                break;
            } while (true);
        }

        private static void GenerateRandomIntCollection(int n, out List<int> collection)
        {
            collection = new List<int>();
            for (var i = 0; i < n; i++)
            {
                collection.Add(new Random().Next(-10_000, 10_001));
            }
        }

        private static void GetLastDigitOfNumbers(List<int> collection, out List<int> updatedCollection)
        {
            updatedCollection = collection.Select(x => Math.Abs(x) % 10).ToList();
            
            var updatedCollection1 = 
                from el in collection 
                select el % 10;
        }

        private static void GroupByLastDigit(List<int> collection, out IEnumerable<IGrouping<int, int>> updatedCollection)
        {
            updatedCollection = collection.GroupBy(x => x % 10);
            var updatedCollection1 =
                from el in collection
                group el by el % 10
                into elNew
                select elNew;
        }

        private static void GetAmountOfPositiveEvenNumbers(List<int> collection, out int amount)
        {
            amount = collection.Count(el => el >= 0 && el % 2 == 0);
            var amount1 =
                (from el in collection 
                where el >= 0 && el % 2 == 0
                select el).Count();
        }

        private static void GetEvenNumbersSum(List<int> collection, out int sum)
        {
            sum = collection.Where(el => el % 2 == 0).Sum();
            var sum1 = 
                (from el in collection
                where el % 2 == 0
                select el).Sum();
        }

        private static void SortNumbersByFirstAndLastDigit(List<int> collection, out List<int> updatedCollection)
        {
            updatedCollection = collection.OrderBy(el => Math.Abs(el).ToString()[0])
                .ThenBy(el => el % 10).ToList();
            var updatedCollection1 = 
                from el in collection
                orderby Math.Abs(el).ToString()[0], el % 10
                select el;
        }

        private static void PrintCollection(List<int> collection) 
            => collection.ForEach(number => Console.Write($"{number} "));
        
        static void Main(string[] args)
        {
            GetNumberOfCollection(out var n);
            GenerateRandomIntCollection(n, out var collection);

            Console.WriteLine();
            
            Console.WriteLine("Case1:");
            GetLastDigitOfNumbers(collection, out var updatedCollection1);
            PrintCollection(updatedCollection1);
            
            Console.WriteLine();
            
            Console.WriteLine("Case2:");
            GroupByLastDigit(collection, out var updatedCollection2);
            foreach (var group in updatedCollection2)
            {
                Console.WriteLine(group.Key);
                PrintCollection(group.ToList());
            }
            
            Console.WriteLine();
            
            Console.WriteLine("Case3:");
            GetAmountOfPositiveEvenNumbers(collection, out var amount);
            Console.WriteLine(amount);
            
            Console.WriteLine();
            
            Console.WriteLine("Case4:");
            GetEvenNumbersSum(collection, out var sum);
            Console.WriteLine(sum);
            
            Console.WriteLine();
            
            Console.WriteLine("Case5:");
            SortNumbersByFirstAndLastDigit(collection, out var updatedCollection5);
            PrintCollection(updatedCollection5);
        }
    }
}