using System;

namespace Task_02
{
    class RegularPolygon
    {
        public int N { get; set; }
        public double R { get; set; }

        public RegularPolygon(int n = 0, double r = 0)
        {
            N = n;
            R = r;
        }

        public double Perimeter
        {
            get
            {
                return N * 2 * R * Math.Tan(Math.PI / N);
            }
        }

        public double Square
        {
            get
            {
                return Perimeter * R / 2;
            }
        }

        public string PolygonData()
        {
            return N + " " + R + " " + Square + " " + Perimeter;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var r = double.Parse(Console.ReadLine());

            RegularPolygon regPol = new RegularPolygon(n, r);
            Console.WriteLine(regPol.Perimeter);
            Console.WriteLine(regPol.Square);
        }
    }
}