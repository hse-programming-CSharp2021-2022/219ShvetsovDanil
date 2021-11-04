using System;

namespace Task_01
{
    public class MyComplex
    {
        // Declaration of auto-implemented properties.
        private double Re { get; }
        private double Im { get; }

        // Constructor to assign properties variables values.
        public MyComplex(double xre, double xim)
        {
            Re = xre;
            Im = xim;
        }

        // Overloading different operations.
        public static MyComplex operator ++(MyComplex mc) => 
            new (mc.Re + 1, mc.Im + 1);

        public static MyComplex operator --(MyComplex mc) =>
            new (mc.Re - 1, mc.Im - 1);

        public static bool operator true(MyComplex f) => f.Mod() > 1.0;

        public static bool operator false(MyComplex f) => f.Mod() <= 1.0;

        public static MyComplex operator +(MyComplex a, MyComplex b) => 
            new (a.Re + b.Re, a.Im + b.Im);

        public static MyComplex operator -(MyComplex a, MyComplex b) => 
            new(a.Re - b.Re, a.Im - b.Im);

        public static MyComplex operator *(MyComplex a, MyComplex b) =>
            new(a.Re * b.Re - a.Im * b.Im, b.Re * b.Im + a.Re * a.Im);

        public static MyComplex operator /(MyComplex a, MyComplex b) => 
            new ((a.Re * a.Im + b.Re * b.Im) / (Math.Pow(a.Im, 2) + Math.Pow(b.Im, 2)),
                (b.Re * b.Im - a.Re * a.Im) / (Math.Pow(a.Im, 2) + Math.Pow(b.Im, 2)));

        // Method Mod() which returns module of complex number.
        public double Mod() => Math.Abs(Re * Re + Im * Im);

        public override string ToString() => $"{Re} + {Im}";
    }
}