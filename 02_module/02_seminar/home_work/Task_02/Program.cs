using System;

namespace Task_02
{
    class Program
    {
        private static void PrintFirstPlate(ConsolePlate cp1)
        {
            Console.ForegroundColor = cp1.PlateColor;
            Console.BackgroundColor = cp1.BackgroundColor;
            Console.Write(cp1.PlateChar);
        }
        
        private static void PrintSecondPlate(ConsolePlate cp2)
        {
            Console.ForegroundColor = cp2.PlateColor;
            Console.BackgroundColor = cp2.BackgroundColor;
            Console.Write(cp2.PlateChar);
        }
        
        static void Main(string[] args)
        {
            try
            {
                ConsolePlate cp1 = new('X', ConsoleColor.White, ConsoleColor.Red);
                ConsolePlate cp2 = new('O', ConsoleColor.White, ConsoleColor.Magenta);
                
                int n;
                do
                {
                    Console.Write("Enter number n: ");
                    if (!int.TryParse(Console.ReadLine(), out n) || n is (< 2 or > 35))
                        continue;
                    break;
                } while (true);

                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                PrintFirstPlate(cp1);
                            }
                            else
                            {
                                PrintSecondPlate(cp2);
                            }
                        }
                        else
                        {
                            if (j % 2 != 0)
                            {
                                PrintFirstPlate(cp1);
                            }
                            else
                            {
                                PrintSecondPlate(cp2);
                            }
                        }
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}