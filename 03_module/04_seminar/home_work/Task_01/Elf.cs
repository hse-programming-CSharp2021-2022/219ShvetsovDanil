using System;

namespace Task_01
{
    public sealed class Elf : Creature
    {
        public override string Name { get; set; }
        
        public override string Location { get; set; }

        public Elf(string name, string location) => (Name, Location) = (name, location);
        
        public override void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Текущее местоположение: {Location}. Звезды светят не так ярко как " +
                              $"обычно. Цветы увядают. Листья предсказывают " +
                              $"идти в {e.Message}");
            Location = e.Message;
        }
    }
}