using System;

namespace task_03
{
    class TemperatureConverterImp
    {
        public double ConvertFromCelsiusToFahrenheit(double temp)
        {
            return Math.Pow(1.8, -1) * (temp - 32);
        }
        
        public double ConvertFromFahrenheitToCelsius(double temp)
        {
            return 1.8 * temp + 32;
        }
    }
}