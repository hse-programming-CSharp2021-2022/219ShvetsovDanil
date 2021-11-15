using System;

namespace Task_03
{
    class Program
    {
        
        // Разработчики одной крупной компании (HSE company) столкнулись с такой проблемой:
        // HSE company выпускает множество программных продуктов и постоянно их обновляет. 
        // Разработчики поняли, что хранить в Excel-таблице актуальные версии приложений неудобно; 
        // но времени на решение этой задачи у них совсем не осталось.
        // Помогите им!
        //
        // На вход поступают запросы вида: name_of_application new_version.
        // Требуется вывести текущую версию приложения и заменить ее на новую (если оно было в Redis),
        // или же вывести, что такого приложения не существует, и добавить его в Redis.
        
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

            string query;
            Console.WriteLine("Input one of the following commands:\n\nadd <application_name> <version>\n" +
                              "back <application_name>\nget <application_name>\nshow\nhelp\nexit\n");
            while ((query = Console.ReadLine()) != "exit")
            {
                string applicationName;
                string version;
                switch (query)
                {
                    case "add":
                        Console.Write("Enter application name and version: ");
                        string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        (applicationName, version) = (inputLine[0], inputLine[1]);
                        
                        RedisClient.Add($"HSEcompany{applicationName}", version);
                        break;
                    
                    case "back":
                        Console.Write("Enter application name you want to roll back: ");
                        applicationName = Console.ReadLine();

                        RedisClient.Back($"HSEcompany{applicationName}");
                        break;
                    
                    case "get":
                        Console.Write("Enter application name you want to get version of: ");
                        applicationName = Console.ReadLine();
                        
                        RedisClient.Get($"HSEcompany{applicationName}");
                        break;
                    
                    case "show":
                        string[] keys = RedisClient.GetKeys("HSEcompany");
                        foreach (var key in keys)
                        {
                            Console.Write($"{key.Replace("HSEcompany", "")}: ");
                            for (var i = 0; i < RedisClient.GetLength(key); i++)
                            {
                                Console.Write(RedisClient.GetValue(key, i) + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    
                    case "help":
                        Console.Write("\nCommands:\nadd <application_name> <version>\n" +
                        "back <application_name>\nget <application_name>\nshow\nhelp\nexit\nEnter one of them: ");
                        break;
                    
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown command");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}