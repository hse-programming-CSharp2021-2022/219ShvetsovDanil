using System;
using System.Collections.Generic;

namespace Task_02___p._4
{
    class Program
    { 
        private static double GetMinSquare(List<RegularPolygon> list)
        {
            var minValue = list[0].Square;

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i].Square < minValue)
                    minValue = list[i].Square;
            }

            return minValue;
        }

        private static double GetMaxSquare(List<RegularPolygon> list)
        {
            var maxValue = list[0].Square;

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i].Square > maxValue)
                    maxValue = list[i].Square;
            }

            return maxValue;
        }
        
        static void Main(string[] args)
        {
            RegularPolygon regularPolygon = new RegularPolygon();
           
            Console.WriteLine("Initial polygon was created:");
            Console.WriteLine(regularPolygon.PolygonData);
            Console.WriteLine();

            do
            {
                List<RegularPolygon> listObjects = new List<RegularPolygon>();

                // get number of sides and radius
                int n;
                double r;
                var counter = 0;

                do
                {
                    Console.WriteLine($"Object №{counter + 1}:");

                    do
                    {
                        Console.Write("Enter number of sides: ");
                    } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

                    do
                    {
                        Console.Write("Enter radius: ");
                    } while (!double.TryParse(Console.ReadLine(), out r) || r < 0);

                    if (n == 0 && r == 0)
                        break;
                    
                    listObjects.Add(new RegularPolygon(n, r));
                    counter++;

                } while (n != 0 && r != 0);

                var minSquare = GetMinSquare(listObjects);
                var maxSquare = GetMaxSquare(listObjects);
                
                Console.WriteLine();
                Console.WriteLine("New info about all objects:");

                for (var i = 0; i < listObjects.Count; i++)
                {
                    if (listObjects[i].Square == minSquare)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Object {i + 1}: " + listObjects[i].PolygonData);
                    }
                    else if (listObjects[i].Square == maxSquare)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Object {i + 1}: " + listObjects[i].PolygonData);
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.WriteLine($"Object {i + 1}: " + listObjects[i].PolygonData);
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Press BACKSPACE to quit");

            } while (Console.ReadKey(true).Key != ConsoleKey.Backspace);
        }
    }
}