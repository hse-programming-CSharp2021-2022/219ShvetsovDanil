# pragma warning disable

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_01
{
    public static class Converter
    {
        #region Fields
        private static readonly BinaryFormatter BinaryFormatter = new();
        private static readonly XmlSerializer XmlSerializer = new(typeof(University[]), new[]
        {
            typeof(University),
            typeof(Department),
            typeof(Human),
            typeof(Professor)
        });
        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            AllowTrailingCommas = true,
            WriteIndented = true
        };
        #endregion
        
        #region Serializers
        public static void SerializeObjectToBinaryType(out string filename, University[] universities)
        {
            filename = "binaryFile.txt";
            
            using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter.Serialize(fs, universities);
            }
            
            Console.WriteLine("Binary serialization was successfully done!");
        }

        public static void SerializeObjectToXmlType(out string filename, University[] universities)
        {
            filename = "xmlFile.xml";
            
            using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer.Serialize(fs, universities);
            }
            
            Console.WriteLine("XML serialization was successfully done!");
        }

        public static async Task SerializeObjectToJsonType(string filename, University[] universities)
        {
            using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                await JsonSerializer.SerializeAsync(fs, universities, JsonSerializerOptions);
            }

            Console.WriteLine("JSON serialization was successfully done!");
        }
        #endregion

        #region Deserializers
        public static void DeserializeObjectFromBinaryType(string filename, out University[] universities)
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                universities = (University[]) BinaryFormatter.Deserialize(fs);
            }

            Console.WriteLine("Binary deserialization was successfully done!");
        }

        public static void DeserializeObjectFromXmlType(string filename, out University[] universities)
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                universities = (University[]) XmlSerializer.Deserialize(fs);
            }

            Console.WriteLine("XML deserialization was successfully done!");
        }

        public static async Task<University[]> DeserializeObjectFromJsonType(string filename)
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                var universities = await JsonSerializer.DeserializeAsync<University[]>(fs, JsonSerializerOptions);
                
                Console.WriteLine("JSON deserialization was successfully done!");
                return universities;
            }
        }
        #endregion
    }
}