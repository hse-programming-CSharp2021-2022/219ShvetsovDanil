using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Santa santa = new Santa("Santa");
                SnowMaiden snowMaiden = new SnowMaiden("SnowMaiden");

                List<Person> people = new List<Person>();
                people.Add(santa);
                people.Add(snowMaiden);
                int n = 10;
                for (int i = 0; i < n; i++)
                {
                    people.Add(new Child((i + 1).ToString()));
                }

                var flag = true;
                var isDeleted = false;
                while (true)
                {
                    Random random = new Random();
                    if (random.Next(1, 101) <= 10)
                    {
                        try
                        {
                            santa.Give(santa);
                            Console.WriteLine(santa);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            if (flag)
                            {
                                santa.Request(snowMaiden, random.Next(1, 5));
                            }

                            if (isDeleted)
                            {
                                break;
                            }

                            goto CrucialSituations;
                        }
                    }

                    else
                    {
                        int randomPersonNum = random.Next(1, people.Count);
                        try
                        {
                            santa.Give(people[randomPersonNum]);
                            Console.WriteLine(people[randomPersonNum]);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                            people.RemoveAt(randomPersonNum);
                            if (randomPersonNum == 1 && !isDeleted)
                            {
                                flag = false;
                                isDeleted = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            if (flag)
                            {
                                santa.Request(snowMaiden, random.Next(1, 5));
                            }

                            if (isDeleted)
                            {
                                break;
                            }

                            goto CrucialSituations;
                        }
                    }

                    if (flag)
                    {
                        santa.Request(snowMaiden, random.Next(1, 5));
                    }

                    CrucialSituations:
                    if (santa.sack.Count == 0)
                    {
                        break;
                    }

                    if (people.Count == 1)
                    {
                        break;
                    }
                }

                Console.WriteLine("To exit the program press BACKSPACE");
            } while (Console.ReadKey().Key != ConsoleKey.Backspace);
        }
    }
}