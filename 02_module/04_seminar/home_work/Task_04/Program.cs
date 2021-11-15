using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task_04
{
    class Program
    {
        private static void PrintSuccessOfOperation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The query has successfully processed!");
            Console.ResetColor();
        }

        private static void InformAboutError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect input! Try again!");
            Console.ResetColor();
        }

        private static void PrintProductList(string[] productList)
        {
            if (productList != Array.Empty<string>())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Product list is following:");
                Console.ResetColor();
                foreach (var product in productList)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Storage list is empty or does not exist!");
                Console.ResetColor();
            }
        }

        private static void PrintHelpTool()
        {
            Console.Write("You can execute following commands:\n\n" +
                              "add <storage_name> <product_name>\n" +
                              "get <storage_name>\n" +
                              "exist <storage_name> <product_name>\n" +
                              "help\n" +
                              "exit\n\nChoose one of them and type: ");
        }
        
        private static (string query, List<string>) ParseInputToList(string inputLine)
        {
            List<string> inputInfo = new();
            string[] inputArray = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string query = inputArray[0];

            foreach (string word in inputArray[1..])
            {
                inputInfo.Add(new Regex(@"<.*?>").Match(word).Value[1..^1]);
            }
            
            return (query, inputInfo);
        }
        
        static void Main(string[] args)
        {
            try
            {
                RedisClient.Connect();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            string input;
            Console.WriteLine("Welcome to a warehouse LIFE!\n");
            PrintHelpTool();
            Input:
            while ((input = Console.ReadLine()) != "exit")
            {
                string query;
                List<string> userInput;
                try
                {
                    (query, userInput) = ParseInputToList(input);
                }
                catch
                {
                    InformAboutError();
                    goto Input;
                }

                switch (query)
                {
                    case "add":
                        if (userInput.Count != 2)
                        {
                            InformAboutError();
                        }
                        else
                        {
                            (string storageName, string productName) = (userInput[0], userInput[1]);
                            RedisClient.Add($"L{storageName}", productName);
                            PrintSuccessOfOperation();
                        }
                        break;
                    
                    case "get":
                        if (userInput.Count != 1)
                        {
                            InformAboutError();
                        }
                        else
                        {
                            string storageName = userInput[0];
                            string[] productList = RedisClient.Get($"L{storageName}");
                            PrintProductList(productList);
                            PrintSuccessOfOperation();
                        }
                        break;
                    
                    case "exist":
                        if (userInput.Count != 2)
                        {
                            InformAboutError();
                        }
                        else
                        {
                            (string storageName, string productName) = (userInput[0], userInput[1]);
                            if (RedisClient.Exist($"L{storageName}", productName))
                            {
                                Console.WriteLine($"{productName} exists in {storageName.Replace("L", "")}!");
                            }
                            else
                            {
                                Console.WriteLine($"{productName} does not exist in {storageName.Replace("L", "")}!");
                            }
                            PrintSuccessOfOperation();
                        }
                        break;
                    
                    case "help":
                        PrintHelpTool();
                        break;
                    
                    default:
                        InformAboutError();
                        break;
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}