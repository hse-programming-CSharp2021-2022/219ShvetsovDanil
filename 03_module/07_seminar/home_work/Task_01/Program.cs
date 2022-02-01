using System;
using System.Text;

namespace Task_01
{
    internal struct Person : IComparable<Person>
    {
        private string _name;
        private string _lastname;
        private int _age;

        public Person(string name, string lastname, string age)
        {
            _name = name;
            _lastname = lastname;
            if (!int.TryParse(age, out _age) || _age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int CompareTo(Person anotherPerson)
        {
            return _age > anotherPerson._age ? 1 : -1;
        }

        public override string ToString()
        {
            return $"Name: {_name}; Lastname: {_lastname}; Age: {_age}";
        }
    }
    
    class Program
    {
        private static Random _random = new();

        private static string GenerateWord()
        {
            StringBuilder name = new();
            for (var i = 0; i < _random.Next(4, 8); i++)
            {
                
                name.Append((char)(_random.Next(97, 123)));
            }

            return name.ToString()[0].ToString().ToUpper() + name.ToString()[1..];
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter amount of characters: ");
            int charactersAmount = int.Parse(Console.ReadLine());
            Person[] characters = new Person[charactersAmount];

            for (var i = 0; i < characters.Length; i++)
            {
                characters[i] = new Person(GenerateWord(), GenerateWord(), _random.Next(1, 101).ToString());
            }

            foreach (var person in characters)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("— — — — — — — — — — — — — — — — — — — — — —");
            
            Array.Sort(characters);
            foreach (var person in characters)
            {
                Console.WriteLine(person);
            }
        }
    }
}