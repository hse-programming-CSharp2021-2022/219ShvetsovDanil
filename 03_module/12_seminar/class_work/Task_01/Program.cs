using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Task_01
{
    [Serializable]
    public class Student
    {
        public string Lastname { get; set; }
        public int CourseNumber { get; set; }

        public Student() { }

        public Student(string lastname, int courseNumber) => (Lastname, CourseNumber) = (lastname, courseNumber);

        public override string ToString() => $"Student: {Lastname}, course: {CourseNumber}";
    }

    [Serializable]
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Group() { }

        public Group(string name, List<Student> students) => (Name, Students) = (name, students);
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Group[]));

            Group group1 = new Group("A",
                new List<Student>
                {
                    new("Ivanov", 1),
                    new("Petrov", 1),
                    new("Sidorov", 1),
                });
            Group group2 = new Group("B", new List<Student>
                {
                    new ("Messi", 1),
                    new ("Neymar", 1),
                    new ("Ronaldo", 1),
                });

            using (FileStream file = new("f1.txt", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, new[] {group1, group2});
            }

            using (FileStream file = new ("f1.txt", FileMode.OpenOrCreate))
            {
                var groups = (Group[])binaryFormatter.Deserialize(file);
                foreach (var group in groups)
                {
                    Console.WriteLine(group.Name);
                    Console.WriteLine(String.Join(" -<>- ", group.Students));
                }
            }
            Console.WriteLine("\n— — — — — — — — — — —\n");
            
            using (FileStream file = new("f2.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, new[] {group1, group2});
            }
            
            using (FileStream file = new ("f2.xml", FileMode.OpenOrCreate))
            {
                var groups = (Group[])xmlSerializer.Deserialize(file);
                foreach (var group in groups)
                {
                    Console.WriteLine(group.Name);
                    Console.WriteLine(String.Join(" ", group.Students));
                }
            }

            Console.WriteLine("\n— — — — — — — — — — —\n");
            
            var settings = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(new[] {group1, group2}, settings);
            Console.WriteLine(json);
            var groups1 = JsonSerializer.Deserialize<Group[]>(json, settings);
            foreach (var group in groups1)
            {
                Console.WriteLine(group.Name);
                Console.WriteLine(String.Join(" ", group.Students));
            }
            
            Console.WriteLine("\n— — — — — — — — — — —\n");
        }
    }
}