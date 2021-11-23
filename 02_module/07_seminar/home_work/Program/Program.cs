using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        private static string CreateName()
        {
            var name = String.Empty;
            const int leftUpperAsciiBorder = 65;
            const int rightUpperAsciiBorder = 90;
            const int leftLowerAsciiBorder = 97;
            const int rightLowerAsciiBorder = 122;

            List<char> chars = new();
            for (var i = leftUpperAsciiBorder; i <= rightUpperAsciiBorder; i++)
            {
                chars.Add((char)i);
            }
            for (var i = leftLowerAsciiBorder; i <= rightLowerAsciiBorder; i++)
            {
                chars.Add((char)i);
            }
            
            for (var i = 0; i < new Random().Next(3, 10); i++)
            {

                name += chars[new Random().Next(0, chars.Count - 1)];
            }

            return name;
        }

        private static int CreateSpeed() => new Random().Next(10, 18);

        private static int CreateStrength() => new Random().Next(-50, 51);
        
        private static void PrintCreatureInfo(Creature[] creatures)
        {
            foreach (Creature creature in creatures)
            {
                Console.WriteLine(creature);
            }
        }

        private static void PrintNewStaffMessage(Creature[] creatures)
        {
            foreach (Creature creature in creatures)
            {
                if (creature is Dwarf)
                {
                    Dwarf.MakeNewStaff();
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    try
                    {
                        Console.Write("Enter amount of creatures: ");
                        n = int.Parse(Console.ReadLine());
                        if (n is (<= 0 or > 100))
                        {
                            throw new AmountOfCreaturesException("Incorrect amount of creatures!");
                        }

                        break;
                    }
                    catch (AmountOfCreaturesException creaturesException)
                    {
                        Console.WriteLine(creaturesException.Message + " Try again!");
                    }
                    catch (ArgumentException argumentException)
                    {
                        Console.WriteLine(argumentException.Message + " Try again!");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message + " Try again!");
                    }
                } while (true);

                Console.WriteLine($"Trying to create {n} creatures...");

                Creature[] creatures = new Creature[n];
                for (var i = 0; i < creatures.Length; i++)
                {
                    Random random = new Random();
                    double possibility = random.Next(0, 11);
                    if (possibility <= 2)
                    {
                        do
                        {
                            try
                            {
                                creatures[i] = new Creature(CreateName(), CreateSpeed());
                                break;
                            }
                            catch (IncorrectCreatureNameException incorrectCreatureNameException)
                            {
                                Console.WriteLine(incorrectCreatureNameException.Message + " Try again!");
                            }
                            catch (IncorrectCreatureSpeedException incorrectCreatureSpeedException)
                            {
                                Console.WriteLine(incorrectCreatureSpeedException.Message + " Try again!");
                            }
                        } while (true);
                    }
                    else if (possibility is (> 2 and <= 6))
                    {
                        do
                        {
                            try
                            {
                                creatures[i] = new Dwarf(CreateName(), CreateSpeed(), CreateStrength());
                                break;
                            }
                            catch (IncorrectCreatureNameException incorrectCreatureNameException)
                            {
                                Console.WriteLine(incorrectCreatureNameException.Message + " Try again!");
                            }
                            catch (IncorrectCreatureSpeedException incorrectCreatureSpeedException)
                            {
                                Console.WriteLine(incorrectCreatureSpeedException.Message + " Try again!");
                            }
                        } while (true);
                    }
                    else
                    {
                        do
                        {
                            try
                            {
                                creatures[i] = new Elf(CreateName(), CreateSpeed());
                                break;
                            }
                            catch (IncorrectCreatureNameException incorrectCreatureNameException)
                            {
                                Console.WriteLine(incorrectCreatureNameException.Message + " Try again!");
                            }
                            catch (IncorrectCreatureSpeedException incorrectCreatureSpeedException)
                            {
                                Console.WriteLine(incorrectCreatureSpeedException.Message + " Try again!");
                            }
                        } while (true);
                    }
                }

                Console.WriteLine("\nAt least creatures were created!!! Let's see them!\n");

                PrintCreatureInfo(creatures);
                PrintNewStaffMessage(creatures);

                Console.WriteLine();
                Console.WriteLine("Press Backspace to exit the program!");
            } while (Console.ReadKey().Key != ConsoleKey.Backspace);
            
            Console.WriteLine();
            Console.WriteLine("Good luck!");
        }
    }
}