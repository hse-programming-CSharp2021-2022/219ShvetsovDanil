using System;

namespace Task_01
{
    public class Shape
    {
        protected const double Pi = Math.PI;
        public virtual double Area() => 0.0;
        
        public override string ToString()
        {
            return $"Square = {Area():F3}";
        }
    }
    
    class Circle : Shape
    {
        public Circle(double r)
        {
            R = r;
        }
        private double R { get; }

        public override double Area()
        {
            return 2 * R * Pi;
        }
    }

    class Cylinder : Shape
    {
        public Cylinder(double r, double h)
        {
            R = r;
            H = h;
        }
        private double R { get; }
        private double H { get; }

        public override double Area()
        {
            return 2 * Pi * R * (R + H);
        }
    }
    
    class Sphere : Shape
    {
        public Sphere(double r)
        {
            R = r;
        }
        private double R { get; }

        public override double Area()
        {
            return 4 * Pi * R * R;
        }
    }
}