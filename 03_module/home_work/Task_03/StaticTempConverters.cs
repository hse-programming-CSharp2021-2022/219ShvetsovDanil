using System;

namespace task_03
{
    class StaticTempConverters
    {
        public static double ConvertFromCelsiusToKelvin(double temp)
        {
            return temp + 273.15;
        }
        
        public static double ConvertFromKelvinToCelsius(double temp)
        {
            return temp - 273.15;
        }
        
        public static double ConvertFromCelsiusToRankin(double temp)
        {
            return (temp + 273.15) * 1.8;
        }
        
        public static double ConvertFromRankinToCelsius(double temp)
        {
            return (temp - 491.67) * Math.Pow(1.8, -1);
        }
        
        public static double ConvertFromCelsiusToReaumur(double temp)
        {
            return temp * 0.8;
        }
        
        public static double ConvertFromReaumurToCelsius(double temp)
        {
            return temp * 1.2;
        }
    }
}