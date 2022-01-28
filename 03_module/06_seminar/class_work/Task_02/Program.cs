using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_02
{
    abstract class Animal : IComparable<Animal>
    {
        protected uint Age { get; init; }
        
        public int CompareTo(Animal anotherAnimal)
        {
            if (Age < anotherAnimal.Age) 
                return 1;
            if (Age > anotherAnimal.Age) 
                return -1;
            return 0;
        }
        
        public override string ToString()
        {
            return $"Animal: {GetType().Name}; Age: {Age}";
        }
    }

    interface IRunnable
    {
        void Run() => Console.WriteLine($"{this} is running!");
    }

    interface IJumpable
    {
        void Jump() => Console.WriteLine($"{this} is jumping!");
    }
    
    sealed class Cockroach : Animal, IRunnable
    {
        public uint Speed { get; }

        public Cockroach(uint age, uint speed)
        {
            Age = age;
            Speed = speed;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}; Speed: {Speed}";
        }
    }

    class CockroachComparer : IComparer<Cockroach>
    {
        public int Compare(Cockroach cockroach1, Cockroach cockroach2)
        {
            if (cockroach1?.Speed < cockroach2?.Speed)
                return 1;
            if (cockroach1?.Speed > cockroach2?.Speed)
                return -1;
            return 0;
        }
    }
    
    sealed class Kangaroo : Animal, IJumpable
    {
        public uint JumpLength { get; }

        public Kangaroo(uint age, uint jumpLength)
        {
            Age = age;
            JumpLength = jumpLength;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Jump Length: {JumpLength}";
        }
    }

    class KangarooComparer : IComparer<Kangaroo>
    {
        public int Compare(Kangaroo kangaroo1, Kangaroo kangaroo2)
        {
            if (kangaroo1?.JumpLength < kangaroo2?.JumpLength)
                return 1;
            if (kangaroo1?.JumpLength > kangaroo2?.JumpLength)
                return -1;
            return 0;
        }
    }
    
    sealed class Cheetah : Animal, IRunnable, IJumpable
    {
        public uint Speed { get; }
        public uint JumpLength { get; }

        public Cheetah(uint age, uint speed, uint jumpLength)
        {
            Age = age;
            Speed = speed;
            JumpLength = jumpLength;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Speed: {Speed}; Jump Length: {JumpLength}";
        }
    }

    class Program
    {
        private static Random _random = new();

        static void Main(string[] args)
        {
            int animalsAmount = _random.Next(10, 20);
            Console.WriteLine(animalsAmount);
            var animals = new Animal[animalsAmount];

            for (var count = 0; count < animalsAmount; count += 3)
            {
                if (count == animalsAmount) break;
                animals[count] = new Cockroach(
                    (uint) _random.Next(2, 10), 
                    (uint) _random.Next(5, 11)
                    );
                
                if (count == animalsAmount) break;
                animals[count + 1] = new Kangaroo(
                    (uint) _random.Next(2, 10), 
                    (uint) _random.Next(2, 6)
                    );
                
                if (count == animalsAmount) break;
                animals[count + 2] = new Cheetah(
                    (uint) _random.Next(2, 10), 
                    (uint) _random.Next(5, 11),
                    (uint) _random.Next(2, 5)
                    );
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("— — — — — — — — — — — — — — — —");
            
            Array.Sort(animals);
            
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("— — — — — — — — — — — — — — — —");
            
            List<Cockroach> cockroaches = new();
            foreach (var animal in animals)
            {
                if (animal is Cockroach)
                    cockroaches.Add(animal as Cockroach);
            }
            cockroaches.Sort(new CockroachComparer());

            foreach (var cockroach in cockroaches)
            {
                Console.WriteLine(cockroach);
            }
            Console.WriteLine("— — — — — — — — — — — — — — — —");

            List<Kangaroo> kangaroos = new();
            foreach (var animal in animals)
            {
                if (animal is Kangaroo)
                    kangaroos.Add(animal as Kangaroo);
            }
            kangaroos.Sort(new KangarooComparer());

            foreach (var kangaroo in kangaroos)
            {
                Console.WriteLine(kangaroo);
            }
        }
    }
}