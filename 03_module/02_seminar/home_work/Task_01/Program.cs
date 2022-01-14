using System;
using System.Collections.Generic;

namespace Task_01
{
    class Program
    {
        private static readonly Random s_random = new();
        
        private static void GetPlantsAmount(out int amount)
        {
            do
            {
                Console.Write("Enter amount of plants: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out var n) || n <= 0)
                {
                    Console.WriteLine("Incorrect amount of plants! Try again!");
                    continue;
                }
                
                amount = n;
                break;
                
            } while (true);
        }

        private static void CreatePlantArray(int amount, out Plant[] plants)
        {
            Plant[] tmpPlants = new Plant[amount];

            var counter = 0;
            var errorCounter = 0;
            
            do
            {
                try
                {
                    tmpPlants[counter] = new Plant
                    (
                        s_random.Next(-100, 200) + s_random.NextDouble(),
                        s_random.Next(-100, 200) + s_random.NextDouble(),
                        s_random.Next(-100, 200) + s_random.NextDouble()
                    );
                    counter++;
                }
                catch (ArgumentException e)
                {
                    errorCounter++;
                    // Console.WriteLine(e.Message);
                }
            } while (counter != amount);

            Console.ForegroundColor = ConsoleColor.Red;
            var infoMessage = errorCounter > 1 ? "errors" : "error";
            Console.WriteLine($"Info!\nDuring plants creation there occured {errorCounter} {infoMessage}.");
            Console.ResetColor();

            plants = tmpPlants;
        }

        private static void PrintPlantInfo(Plant[] plants)
        {
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            GetPlantsAmount(out int n);
            Console.WriteLine();
            
            CreatePlantArray(amount: n, out Plant[] plants);
            Console.WriteLine();
            
            // Output 1.
            PrintPlantInfo(plants);

            // Output 2.
            Array.Sort(plants, delegate(Plant plant1, Plant plant2)
            {
                return plant1.Growth < plant2.Growth ? 1 : -1;
            });
            PrintPlantInfo(plants);
            
            // Output 3.
            Array.Sort(plants, (plant1, plant2) => plant1.FrostResistance > plant2.FrostResistance ? 1 : -1);
            PrintPlantInfo(plants);
            
            // Output 4.
            Comparison<Plant> comp = (plant1, plant2) => plant1.CompareTo(plant2);
            Array.Sort(plants, comp);
            PrintPlantInfo(plants);
            
            // Output 5.
            var plants2 = Array.ConvertAll(plants,
                plant => plant.FrostResistance % 2 == 0 ?
                    new Plant(plant.Growth, plant.Photosensitivity, plant.FrostResistance / 3) : 
                    new Plant(plant.Growth, plant.Photosensitivity, plant.FrostResistance / 2));
            PrintPlantInfo(plants2);
        }
    }
}