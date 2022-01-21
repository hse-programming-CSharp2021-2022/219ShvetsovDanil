namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new("Гендальф", "A");

            Creature[] creatures =
            {
                new Hobbit("Голлум", "B"),
                new Hobbit("Фродо", "C"),
                new Hobbit("Трандуил", "D"),
                new Hobbit("Саурон", "E"),
                new Human("Боромир", "F"),
                new Human("Арагорн", "G"),
                new Dwarf("Гимли", "H"),
                new Elf("Леголас", "I")
            };

            foreach (var creature in creatures)
            {
                wizard.RaiseRingIsFoundEvent += creature.RingIsFoundEventHandle;
            }
            
            wizard.SomeThisIsChangedInTheAir();
        }
    }
}