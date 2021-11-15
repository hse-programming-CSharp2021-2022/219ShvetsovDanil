using System;
using System.Linq;
using StackExchange.Redis;

namespace Task_03
{
    public static class RedisClient
    {
        public const uint MaxCount = 5;
        
        private static ConnectionMultiplexer _connection;
        private static IDatabase _database;
        private static IServer _server;

        private static readonly string _connectionString = "redis-12319.c269.eu-west-1-3.ec2.cloud.redislabs.com";
        private static readonly int _port = 12319;
        private static readonly string _password = "JtT5Bu2kOZ4pthfFySPZUx7P0s3LQwRT";
        private static readonly int _connectTimeout = 10000;
        private static readonly bool _allowAdmin = true;
        
        public static void Connect()
        {
            _connection = ConnectionMultiplexer.Connect(
                $"{_connectionString}:{_port},password={_password}," +
                $"ConnectTimeout={_connectTimeout},allowAdmin={_allowAdmin}");
            _database = _connection.GetDatabase();
            _server = _connection.GetServer(_connectionString, _port);
        }
        
        private static bool Exist(string key) => _database.KeyExists(key);
        
        private static void SetValue(string key, string value) => 
            _database.ListRightPush(key, value);
        
        public static string GetValue(string key, int index) => _database.KeyType(key) is RedisType.List ? _database.ListGetByIndex(key, index) : _database.StringGet(key);

        public static long GetLength(string key) => _database.KeyType(key) is RedisType.List ? _database.ListLength(key) : 1;
        
        public static void Add(string key, string value)
        {
            if (_database.ListLength(key) >= MaxCount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There's already exist maximum count = {MaxCount} versions! The first one will be deleted!");
                Console.ResetColor();
                _database.ListLeftPop(key);
            }
            
            SetValue(key, value);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Version {value} is added!");
            Console.ResetColor();
        }

        public static void Back(string key)
        {
            if (Exist(key) && _database.ListLength(key) is not 1)
            {
                _database.ListRightPop(key);
                Console.WriteLine($"The application is rolled back to previous version: {_database.ListGetByIndex(key, _database.ListLength(key) - 1)}");
            }
            else
            {
                _database.KeyDelete(key);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No previous version! Application is deleted!");
                Console.ResetColor();
            }
        }

        public static void Get(string key)
        {
            if (Exist(key))
            {
                Console.WriteLine($"The version of {key.Replace("HSEcompany", "")} is {_database.ListGetByIndex(key, _database.ListLength(key) - 1)}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There's no such application!");
                Console.ResetColor();
            }
        }

        public static string[] GetKeys(string keyBeginning) =>
            _server.Keys(pattern: $"{keyBeginning}*").Select(x => x.ToString()).ToArray();
    }
}