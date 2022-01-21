using System;

namespace Task_01
{
    public sealed class Dwarf : Creature
    {
        public override string Name { get; set; }
        
        public override string Location { get; set; }

        public Dwarf(string name, string location) => (Name, Location) = (name, location);
        
        public override void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Текущее местоположение: {Location}. " +
                              $"Точим топоры, собираем припасы! Выдвигаемся в {e.Message}");
            Location = e.Message;
        }
    }
}