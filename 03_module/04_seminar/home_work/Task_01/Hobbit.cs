using System;

namespace Task_01
{
    public sealed class Hobbit : Creature
    {
        public override string Name { get; set; }
        
        public override string Location { get; set; }

        public Hobbit(string name, string location) => (Name, Location) = (name, location);

        public override void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Текущее местоположение: {Location}. Покидаю Шир! Иду в {e.Message}");
            Location = e.Message;
        }
    }
}