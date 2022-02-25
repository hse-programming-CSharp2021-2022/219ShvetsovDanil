using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GetCollectionLength(out var n);
            InsertRandomNumbersInNewCollection(n, out var collection);
            
            GetSquareOfNumbersCollection(collection, out var updatedCollection1);
            PrintOldAndUpdatedData(collection, updatedCollection1);
            
            GetPositiveTwoDigitNumbersCollection(collection, out var updatedCollection2);
            PrintOldAndUpdatedData(collection, updatedCollection2);
            
            GetEvenNumbersSortedByDescendingCollection(collection, out var updatedCollection3);
            PrintOldAndUpdatedData(collection, updatedCollection3);
            
            GroupNumbersByLength(collection, out var updatedCollection4);
            Console.WriteLine();
            Console.WriteLine("Initial collection:");
            PrintCollection(collection);
            Console.Write("\nUpdated collection: ");
            foreach (var group in updatedCollection4)
            {
                Console.WriteLine();
                Console.WriteLine(group.Key);
                PrintCollection(group.ToList());
            }
        }

        private static void PrintOldAndUpdatedData<T>(List<T> oldCollection, List<T> updatedCollection)
            where T: struct
        {
            Console.WriteLine();
            Console.WriteLine("Initial collection:");
            PrintCollection(oldCollection);
            Console.WriteLine("\nUpdated collection: ");
            PrintCollection(updatedCollection);
            Console.WriteLine();
        }
        
        private static void PrintCollection<T>(List<T> collection)
            where T : struct
            => collection.ForEach(el => Console.Write($"{el} "));
        
        private static void GetCollectionLength(out int n)
        {
            do
            {
                Console.Write("Enter amount of numbers in collection: ");

                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Incorrect input! Try again!");
                    continue;
                }
                break;
            } while (true);
        }

        private static void InsertRandomNumbersInNewCollection(int n, out List<int> collection)
        {
            collection = new List<int>();
            for (var i = 0; i < n; i++)
            {
                collection.Add(new Random().Next(-1_000, 1_001));
            }
        }

        private static void GetSquareOfNumbersCollection(IEnumerable<int> collection, out List<int> updatedCollection)
            => updatedCollection = collection.Select(el => el * el).ToList();
        
        private static void GetPositiveTwoDigitNumbersCollection(IEnumerable<int> collection, out List<int> updatedCollection)
            => updatedCollection = collection.Where(el => el > 0 && el.ToString().Length == 2).ToList();

        private static void GetEvenNumbersSortedByDescendingCollection(IEnumerable<int> collection, out List<int> updatedCollection)
            => updatedCollection = collection.Where(el => el % 2 == 0).OrderByDescending(el => el).ToList();

        private static void GroupNumbersByLength(IEnumerable<int> collection, out IEnumerable<IGrouping<int, int>> updatedCollection) 
            => updatedCollection = collection.GroupBy(el => Math.Abs(el).ToString().Length);
    }
}