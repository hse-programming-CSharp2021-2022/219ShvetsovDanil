using System;
using StackExchange.Redis;

namespace TaskString
{
    public static class RedisClient
    {
        private static ConnectionMultiplexer _redis;
        private static IDatabase _database;

        public static void Connect()
        {
            _redis = ConnectionMultiplexer.Connect("redis-12319.c269.eu-west-1-3.ec2.cloud.redislabs.com:12319,password=JtT5Bu2kOZ4pthfFySPZUx7P0s3LQwRT,ConnectTimeout=10000,allowAdmin=true");
            _database = _redis.GetDatabase();
        }

        public static string GetSet(string key, string value)
        {
            return _database.StringGetSet(key, value);
        }

        public static bool Exist(string key)
        {
            return _database.KeyExists(key);
        }
        
        public static void Set(string key, string value)
        {
            _database.StringSet(key, value);
        }
    }
}