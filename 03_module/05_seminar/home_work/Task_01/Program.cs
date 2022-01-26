using System;

namespace Task_01
{
    public delegate double Calculate(double x);
    
    internal interface IFunction
    {
        double Function(double x);
    }

    class F : IFunction
    {
        private readonly Calculate _calculate;
        
        public F(Calculate calculate)
        {
            _calculate = calculate;
        }

        public double Function(double x) => _calculate(x);
    }

    class G
    {
        private F _f1, _f2;
        
        public G(F f1, F f2)
        {
            _f1 = f1;
            _f2 = f2;
        }

        public double GF(double x0) => _f1.Function(_f2.Function(x0));
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            F f1 = new(x => Math.Pow(x, 2) - 4);
            F f2 = new(x => Math.Sin(x));

            G g = new(f1, f2);

            for (double i = 0; i <= Math.PI; i += Math.PI / 16)
            {
                Console.WriteLine($"G({i:F4}) — {g.GF(i):F4}");
            }
        }
    }
}