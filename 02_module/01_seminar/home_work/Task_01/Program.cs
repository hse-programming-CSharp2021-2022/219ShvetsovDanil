using System;

namespace Task_01
{
    class Program
    {
        private static string[] SortedPoints(Point a, Point b, Point c)
        {
            var resultArray = new string[3];

            if (a.Ro >= b.Ro && a.Ro >= c.Ro)
            {
                resultArray[2] = a.PointData;
                if (b.Ro >= c.Ro)
                {
                    resultArray[1] = b.PointData;
                    resultArray[0] = c.PointData;
                }
                else
                {
                    resultArray[1] = c.PointData;
                    resultArray[0] = b.PointData;
                }
            }
            else if (b.Ro >= a.Ro && b.Ro >= c.Ro)
            {
                resultArray[2] = b.PointData;
                if (a.Ro >= c.Ro)
                {
                    resultArray[1] = a.PointData;
                    resultArray[0] = c.PointData;
                }
                else
                {
                    resultArray[1] = c.PointData;
                    resultArray[0] = a.PointData;
                }
            }
            else
            {
                resultArray[2] = c.PointData;
                if (a.Ro >= b.Ro)
                {
                    resultArray[1] = a.PointData;
                    resultArray[0] = b.PointData;
                }
                else
                {
                    resultArray[1] = b.PointData;
                    resultArray[0] = a.PointData;
                }
            }

            return resultArray;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Initial output:");
            
            Point a, b, c;
            
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);

            b = new Point(0, 3);
            Console.WriteLine(b.PointData);

            c = new Point();

            double x, y;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);

                c.X = x;
                c.Y = y;
                Console.WriteLine(c.PointData);
                Console.WriteLine();

                if (x == 0 && y == 0)
                    break;
                
                Console.WriteLine("Formatted output:");
                foreach (var s in SortedPoints(a, b, c))
                {
                    Console.WriteLine(s);
                }
            } while (x != 0 && y != 0);
            
            Console.WriteLine("End of program!");
        }
    }
}