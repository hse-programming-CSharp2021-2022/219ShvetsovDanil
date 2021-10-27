using System;

namespace Task_02
{
    class Program
    { 
        private static double GetMinSquare(RegularPolygon[] array)
        {
            var minValue = array[0].Square;

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i].Square < minValue)
                    minValue = array[i].Square;
            }

            return minValue;
        }

        private static double GetMaxSquare(RegularPolygon[] array)
        {
            var maxValue = array[0].Square;

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i].Square > maxValue)
                    maxValue = array[i].Square;
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
                int numObj;
                do
                {
                    Console.Write("Enter quantity of objects: ");
                } while (!int.TryParse(Console.ReadLine(), out numObj) || numObj < 0);

                var arrayObjects = new RegularPolygon[numObj];

                // get number of sides and radius
                int n;
                double r;
                
                for (var i = 0; i < arrayObjects.Length; i++)
                {
                    Console.WriteLine($"Object №{i + 1}:");
                    
                    do
                    {
                        Console.Write("Enter number of sides: ");
                    } while (!int.TryParse(Console.ReadLine(), out n) || n < 3);

                    do
                    {
                        Console.Write("Enter radius: ");
                    } while (!double.TryParse(Console.ReadLine(), out r) || r < 0);

                    arrayObjects[i] = new RegularPolygon(n, r);
                }

                var minSquare = GetMinSquare(arrayObjects);
                var maxSquare = GetMaxSquare(arrayObjects);
                
                Console.WriteLine();
                Console.WriteLine("New info about all objects:");

                for (var i = 0; i < arrayObjects.Length; i++)
                {
                    if (arrayObjects[i].Square == minSquare)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Object {i + 1}: " + arrayObjects[i].PolygonData);
                    }
                    else if (arrayObjects[i].Square == maxSquare)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Object {i + 1}: " + arrayObjects[i].PolygonData);
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.WriteLine($"Object {i + 1}: " + arrayObjects[i].PolygonData);
                    }
                }

                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Press BACKSPACE to quit");

            } while (Console.ReadKey(true).Key != ConsoleKey.Backspace);
        }
    }
}