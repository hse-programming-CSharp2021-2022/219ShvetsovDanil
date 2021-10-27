using System;

namespace Task_02___p._4
{
    class RegularPolygon
    {
        // default constructor = constructor which get initial values 
        public RegularPolygon(int n = 3, double r = 1)
        {
            _n = n;
            _r = r;
        }

        // declaration of fields
        private int _n;
        private double _r;

        // declaration of properties
        private double Perimeter => 2 * _n * _r * Math.Tan(Math.PI / _n);

        public double Square => Perimeter * _r / 2;
        
        // declaration of accessible method PolygonData
        public string PolygonData => $"N = {_n}; R = {_r}; P = {Perimeter:F3}; S = {Square:F3}";
    }
}