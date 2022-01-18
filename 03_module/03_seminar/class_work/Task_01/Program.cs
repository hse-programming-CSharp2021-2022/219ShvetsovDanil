using System;

namespace Task_01
{
    delegate void SquareSizeChanged(double a, double x1, double y1, double x2, double y2);

    class Square
    {
        public event SquareSizeChanged OnSizeChanged;

        public double X1 { get; set; }
        public double Y1 { get; set; }
        
        public double X2 { get; set; }
        public double Y2 { get; set; }
    }
    
    class Program
    {
        private static void SquareConsoleInfo(double a, double x1, double y1, double x2, double y2) => Console.WriteLine($"Square size changed! New length of side: {a:F2}\n" +
                                                                             $"Left upper corner coord: ({x1}, {y1})\n" +
                                                                             $"Right lower corner coord: ({x2}, {y2})\n");
        
        static void Main(string[] args)
        {
            Square s = new();
            s.OnSizeChanged += SquareConsoleInfo;

            while (true)
            {
                Console.WriteLine("Enter 'coords' to input coordinates and 'exit' to quit.");
                switch (Console.ReadLine())
                {
                    case "coords":
                        Console.WriteLine("Enter following (x, y) coordinates of right lower corner:");
                        string[] input = Console.ReadLine()?.Split();
                        var x1 = double.Parse(input[0]);
                        var y1 = double.Parse(input[1]);

                        Console.Write("Enter length of side: ");
                        double a = int.Parse(Console.ReadLine());
                        
                        s.X1 = x1;
                        s.Y1 = y1;
                        s.X2 = x1 - a;
                        s.Y2 = y1 + a;
                        
                        SquareConsoleInfo(a, s.X1, s.Y1, s.X2, s.Y2);
                        continue;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Incorrect command! Try again!");
                        continue;
                }
                break;
            }
        }
    }
}