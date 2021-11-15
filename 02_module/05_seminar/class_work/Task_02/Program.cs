using System;
using Task_02;

namespace Task_02
{
    abstract class Animal
    {
        public Animal(string animalName, int animalAge)
        {
            AnimalName = animalName;
            AnimalAge = animalAge;
        }

        protected string AnimalName { get; }

        protected int AnimalAge { get; }

        public abstract string AnimalSound();

        public abstract string AnimalInfo();
    }

    class Dog : Animal
    {
        public Dog(string animalName, int animalAge, string animalBreed, bool isTrained) : base(animalName, animalAge)
        {
            Breed = animalBreed;
            IsTrained = isTrained;
        }

        private string Breed { get; }
        private bool IsTrained { get; }

        public override string AnimalSound() => "woof-woof";

        public override string AnimalInfo() => $"Breed: {Breed}  Is trained: {IsTrained}    " +
                                               $"Animal name: {AnimalName}   Age: {AnimalAge}    " +
                                               $"Sound: {AnimalSound()}";
    }

    class Cow : Animal
    {
        public Cow(string animalName, int animalAge, int milkCount) : base(animalName, animalAge)
        {
            CountMilk = milkCount;
        }

        private int CountMilk { get; }
        public override string AnimalSound() => "mow-mow";

        public override string AnimalInfo() => $"Milk count: {CountMilk}    Animal name: {AnimalName}    " +
                                               $"Animal age: {AnimalAge}    Sound: {AnimalSound()}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cow = new Cow("Name of cow", 3, 100);
            var dog = new Dog("Name of dog", 4, "any breed", true);

            Console.WriteLine(cow.AnimalInfo());
            Console.WriteLine(dog.AnimalInfo());
        }
    }
}