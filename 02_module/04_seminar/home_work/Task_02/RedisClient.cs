using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;

namespace TaskInt
{
    public static class RedisClient
    {
        private static ConnectionMultiplexer _redis;
        private static IDatabase _database;
        private static IServer _server;

        public static void Connect(string connectionString = "redis-12319.c269.eu-west-1-3.ec2.cloud.redislabs.com")
        {
            _redis = ConnectionMultiplexer.Connect($"{connectionString}:12319,password=JtT5Bu2kOZ4pthfFySPZUx7P0s3LQwRT,ConnectTimeout=10000,allowAdmin=true");
            _database = _redis.GetDatabase();
            _server = _redis.GetServer(connectionString, 12319);
        }

        public static void AddOne(string key)
        {
            if (Exist(key))
            {
                _database.StringIncrement(key);
            }
            else
            {
                _database.StringSet(key, 1);
            }
        }

        public static void RemoveOne(string key)
        {
            if (_database.StringDecrement(key) <= 0)
            {
                _database.KeyDelete(key);
            }
        }

        public static bool Exist(string key)
        {
            return _database.KeyExists(key);
        }
        
        public static long GetAsLong(string key)
        {
            return (long) _database.StringGet(key);
        }

        /// <summary>
        /// Get keys in Redis server with special beginning.
        /// </summary>
        /// <param name="keyBeginning"> Special beginning. </param>
        public static string[] GetKeys(string keyBeginning)
        {
            return _server.Keys(pattern: $"{keyBeginning}*")
                .Select(x => x.ToString())
                .ToArray();
        }
    }
}