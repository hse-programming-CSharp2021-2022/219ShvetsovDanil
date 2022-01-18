using System;

namespace Task_01_2
{
    delegate void SquareSizeChanged(double a);

    class Square
    {
        public event SquareSizeChanged OnSizeChanged;

        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;

        public Square(double x1, double y1, double x2, double y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }
        
        public double X1 
        {
            get => _x1;
            set
            {
                _x1 = value;
                OnSizeChanged?.Invoke(Math.Abs(_x1 - _x2));
            }
        }

        public double Y1
        {
            get => _y1;
            set
            {
                _y1 = value;
                OnSizeChanged?.Invoke(Math.Abs(_y1 - _y2));
            }
        }

        public double X2
        {
            get => _x2;
            set
            {
                _x2 = value;
                OnSizeChanged?.Invoke(Math.Abs(_x1 - _x2));
            }
        }

        public double Y2
        {
            get => _y2;
            set
            {
                _y2 = value;
                OnSizeChanged?.Invoke(Math.Abs(_y1 - _y2));
            }
        }
    }
    
    class Program
    {
        private static void SquareConsoleInfo(double a) => Console.WriteLine($"{a:F2}");
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter following (x, y) coordinates of right lower corner:");
            string[] input = Console.ReadLine()?.Split();
            var x1 = double.Parse(input[0]);
            var y1 = double.Parse(input[1]);
            
            Console.WriteLine("Enter following (x, y) coordinates of left upper corner:");
            string[] input1 = Console.ReadLine()?.Split();
            var x2 = double.Parse(input[0]);
            var y2 = double.Parse(input[1]);
            
            Square s = new(x1, y1, x2, y2);
            s.OnSizeChanged += SquareConsoleInfo;

            while (true)
            {
                Console.WriteLine("Enter side length:");
                var x = double.Parse(Console.ReadLine());
                var y = double.Parse(Console.ReadLine());
                s.X2 = x2;
                s.Y2 = y2;
                if (Console.ReadLine() == "exit")
                {
                    break;
                }
            }
        }
    }
}