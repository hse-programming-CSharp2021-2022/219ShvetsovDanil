using System;
using StackExchange.Redis;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "redis-12319.c269.eu-west-1-3.ec2.cloud.redislabs.com";
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis-12319.c269.eu-west-1-3.ec2.cloud.redislabs.com:12319,password=JtT5Bu2kOZ4pthfFySPZUx7P0s3LQwRT,ConnectTimeout=10000,allowAdmin=true");

            IDatabase database = redis.GetDatabase();
            IServer server = redis.GetServer(connectionString, 12319);

            database.StringSet("test 1", "value 1");
            database.StringSet("test 2", "value 2");

            string str1 = database.StringGet("test 1");
            if (database.KeyExists("test 3"))
            {
                string str3 = database.StringGet("test 3");
                Console.WriteLine(str3);
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine(str1);

        }
    }
}