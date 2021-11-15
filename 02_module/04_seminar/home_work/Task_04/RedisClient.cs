using System;
using StackExchange.Redis;

namespace Task_04
{
    public class RedisClient
    {
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
            _connection = ConnectionMultiplexer.Connect($"{_connectionString}:{_port},password={_password}" +
                                                        $",ConnectTimeout={_connectTimeout},allowAdmin={_allowAdmin}");
            _database = _connection.GetDatabase();
            _server = _connection.GetServer(_connectionString, _port);
        }
        
        public static void Add(string key, string value)
        {
            _database.SetAdd(key, value);
        }
        
        public static string[] Get(string key)
        {
            if (_database.KeyExists(key))
            {
                return _database.SetMembers(key).ToStringArray();
            }
            return Array.Empty<string>();
        }

        public static bool Exist(string key, string value) => _database.SetContains(key, value);
    }
}