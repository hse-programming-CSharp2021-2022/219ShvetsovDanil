using System;

namespace Task_01
{
    class Program
    {
        private static readonly Random Random = new();

        // Sort with anonymous method.
        private static void AnonymousMethodSort(Circle[] circles)
        {
            Array.Sort(circles, delegate(Circle circle1, Circle circle2)
            {
                return circle1.Rad * circle1.Center.Distance(circle1.InitialCoordinates) >
                       circle2.Rad * circle2.Center.Distance(circle2.InitialCoordinates)
                    ? 1
                    : -1;
            });
        }

        // Sort with lambda-expression.
        private static void LambdaExpressionSort(Circle[] circles)
        {
            Array.Sort(circles, (circle1, circle2) 
                => circle1.Rad * circle1.Center.Distance(circle1.InitialCoordinates) > 
                   circle2.Rad * circle2.Center.Distance(circle2.InitialCoordinates) ? 1 : -1);
        }

        // Sort with IComparable interface.
        private static void InterfaceIComparableSort(Circle[] circles)
        {
            Array.Sort(circles);
        }
        
        static void Main(string[] args)
        {
            int amountCircles = Random.Next(3, 8);
            Circle[] circles = new Circle[amountCircles];

            for (var i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle(Random.Next(2, 21), Random.Next(2, 21), Random.Next(2, 11));
            }

            foreach (var circle in circles)
            {
                Console.WriteLine(circle);
            }
            Console.WriteLine("— — — — — — — — — — — — — — — — — — — — — —");
            
            SortChoose:
            Console.Write("Choose sort type (1 - anonymous method / 2 - lambda-expression / 3 - IComparable interface): ");
            string sortType = Console.ReadLine();
            switch (sortType)
            {
                case "1":
                    AnonymousMethodSort(circles);
                    break;
                case "2":
                    LambdaExpressionSort(circles);
                    break;
                case "3":
                    InterfaceIComparableSort(circles);
                    break;
                default:
                    Console.WriteLine("Incorrect sort type is chosen! Try again!");
                    goto SortChoose;
            }
            
            foreach (var circle in circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}