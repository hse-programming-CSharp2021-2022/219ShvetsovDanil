using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        private static readonly Random Random = new();

        private static async Task<double> Integral(Func<double, double> func, int a, int b, int n)
        {
            var correct = 0;
            var minX = a;
            var maxX = b;
            var maxY = (int) Math.Max(func(a), func(b)) + 1;
        
            for (var i = 0; i < n; i++)
            {
                await Task.Run(() =>
                {
                    var x = Random.Next(minX, maxX) + Random.NextDouble();
                    var y = Random.Next(0, maxY) + Random.NextDouble();
                    if (y <= func(x))
                    {
                        correct++;
                    }
                });
            }

            return (double) correct / n * (maxX - minX) * maxY;
        }

        static async Task Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            
            var list = new List<double>();
            for (var i = a; i <= b; i += 2)
            {
                await Task.Run(async() =>
                {
                    var integral = await Integral(x => x * x, i, i + 2, Random.Next(0, 1000));
                    list.Add(integral);
                });
            }
            
            Array.ForEach(list.ToArray(), Console.WriteLine);
        }
    }
}