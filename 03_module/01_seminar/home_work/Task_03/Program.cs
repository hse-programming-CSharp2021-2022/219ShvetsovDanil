using System;

namespace task_03
{
    public delegate double DelegateConvertTemperature(double temperature);
    
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverterImp temperatureConverter = new();
            DelegateConvertTemperature[][] convertTemperatures =
            {
                new DelegateConvertTemperature[]
                {
                    temperatureConverter.ConvertFromCelsiusToFahrenheit,
                    // temperatureConverter.ConvertFromFahrenheitToCelsius
                },
                new DelegateConvertTemperature[] 
                {
                    StaticTempConverters.ConvertFromCelsiusToKelvin,
                    StaticTempConverters.ConvertFromCelsiusToRankin,
                    StaticTempConverters.ConvertFromCelsiusToReaumur,
                    // StaticTempConverters.ConvertFromKelvinToCelsius,
                    // StaticTempConverters.ConvertFromRankinToCelsius,
                    // StaticTempConverters.ConvertFromReaumurToCelsius
                }
            };
            string[] convertStrings =
            {
                "Converted from Celsius to Fahrenheit",
                "Converted from Celsius to Kelvin",
                "Converted from Celsius to Rankin",
                "Converted from Celsius to Reaumur"
            };
            
            double inputTemperature;
            do
            {
                Console.Write("Enter temperature: ");
                var input = Console.ReadLine();

                if (!double.TryParse(input, out inputTemperature))
                {
                    Console.WriteLine("Incorrect input. Try again!");
                    continue;
                }
                Console.WriteLine();
                break;
            } while (true);

            var counter = 0;
            for (var i = 0; i < convertTemperatures.Length; i++)
            {
                for (var j = 0; j < convertTemperatures[i].Length; j++)
                {
                    Console.WriteLine($"{convertStrings[counter]}: " +
                                      $"{convertTemperatures[i][j]?.Invoke(inputTemperature):F3}" +
                                      "\n— — — — — — — — — — — — — — — — — — — — — — — — —");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFinished!");
        }
    }
}