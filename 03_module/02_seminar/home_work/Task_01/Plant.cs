using System;

namespace Task_01
{
    public class Plant : IComparable
    {
        // Private fields.
        private double _growth;
        private double _photosensitivity;
        private double _frostresistance;

        // Public properties.
        public double Growth
        {
            get => _growth;
            set
            {
                if (value is (< 25 or > 100))
                {
                    throw new ArgumentException("Incorrect value!");
                }

                _growth = value;
            }
        }
        
        public double Photosensitivity
        {
            get => _photosensitivity;
            set
            {
                if (value is (< 0 or > 100))
                {
                    throw new ArgumentException("Incorrect value!");
                }

                _photosensitivity = value;
            }
        }

        public double FrostResistance
        {
            get => _frostresistance;
            set
            {
                if (value is (< 0 or > 80))
                {
                    throw new ArgumentException("Incorrect value!");
                }

                _frostresistance = value;
            }
        }
        
        // Constructors.
        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            Growth = growth;
            Photosensitivity = photosensitivity;
            FrostResistance = frostresistance;
        }
        
        // Overriding of ToString() method.
        public override string ToString()
        {
            return $"Plant: growth = {_growth:F2}\tphotosensitivity = {_photosensitivity:F2}\tfrost resistance = {_frostresistance:F2}";
        }
        
        // Overriding of CompareTo() method.
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }
            
            Plant otherPlant = obj as Plant;
            if (otherPlant != null)
            {
                if (_photosensitivity % 2 != 0 && otherPlant._photosensitivity % 2 == 0)
                {
                    return 1;
                }

                return 0;
            }
            throw new ArgumentException("Object is not Plant!");
        }
    }
}