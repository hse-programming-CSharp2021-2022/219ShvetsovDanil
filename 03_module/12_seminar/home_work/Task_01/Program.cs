# pragma warning disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_01
{
    class Program
    {
        private static void CreateAndFillUniversitiesArray(out University[] universities)
        {
            universities = new []
            {
                new University {
                    UniversityName = "Higher school of economics",
                    Departments = new List<Department>
                    {
                        new("Computer science", new List<Human>
                        {
                            new Professor("Ivan Ivanov"),
                            new Professor("Petr Petrov"),
                            new Professor("Sergei Sergeev")
                        })
                    }
                },
                new University {
                    UniversityName = "Moscow State university",
                    Departments = new List<Department>
                    {
                        new("Mathematics", new List<Human>
                        {
                            new Professor("Alexander Alexandrov"),
                            new Professor("John Johnson"),
                            new Professor("Andrew Andrewson")
                        })
                    }
                }
            };
        }
        
        private static void PrintDataFromDeserializedObject(University[] universities)
            => universities.ToList().ForEach(uni => Console.WriteLine($"{uni}\n"));
        
        static void Main(string[] args)
        {
            CreateAndFillUniversitiesArray(out University[] universities);
            
            Converter.SerializeObjectToBinaryType(out var filename, universities);
            Converter.DeserializeObjectFromBinaryType(filename, out var universities1);
            PrintDataFromDeserializedObject(universities1);
            
            Console.WriteLine("— — — — — — — — — — — — — — — —\n");
            
            Converter.SerializeObjectToXmlType(out var filename1, universities);
            Converter.DeserializeObjectFromXmlType(filename1, out var universities2);
            PrintDataFromDeserializedObject(universities2);
            
            Console.WriteLine("— — — — — — — — — — — — — — — —\n");

            var filename2 = "JsonFile.json";
            Converter.SerializeObjectToJsonType(filename2, universities);
            var universities3 = Converter.DeserializeObjectFromJsonType(filename2);
            PrintDataFromDeserializedObject(universities3.Result);
            
            Console.WriteLine("— — — — — — — — — — — — — — — —\n");
        }
    }
}