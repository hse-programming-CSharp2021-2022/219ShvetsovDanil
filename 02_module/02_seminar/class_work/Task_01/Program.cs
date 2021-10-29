using System;

namespace Task_01
{
    class MyComplex   
    { 
        private double Re { get; }
        private double Im { get; }
        
        public MyComplex(double xre, double xim)
        {
            Re = xre; Im = xim;
        }

        public static MyComplex operator ++(MyComplex mc)
        {
            return new MyComplex(mc.Re + 1, mc.Im + 1);
        }
        
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.Re - 1, mc.Im - 1);
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re + b.Re, a.Im + b.Im);
        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re - b.Re, a.Im - b.Im);
        }

        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re * b.Re - a.Im * b.Im, a.Re * b.Re + a.Im * b.Im);
        }

        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex((a.Re * b.Re + a.Im * b.Im) / (b.Re * b.Re + b.Im * b.Im), (b.Re * b.Re - a.Im - a.Im) / (b.Re * b.Re + b.Im * b.Im));
        }

        public override string ToString()
        {
            return Re + " " + Im;
        }

        public double Mod()
        {
            return Math.Abs(Re*Re+Im*Im);
        }
        static public bool operator true(MyComplex f) 
        {
            if (f.Mod() > 1.0) 
                return true;
            return false;
        }
        static public bool operator false(MyComplex f)  
        {
            if (f.Mod() <= 1.0) 
                return true;
            return false;
        } 
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyComplex(5, 15);
            var b = new MyComplex(10, 20);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}