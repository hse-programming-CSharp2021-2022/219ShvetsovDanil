using System;

namespace Task_01
{
    public sealed class Human : Creature
    {
        public override string Name { get; set; }
        
        public override string Location { get; set; }

        public Human(string name, string location) => (Name, Location) = (name, location);
        
        public override void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Текущее местоположение: {Location}. Волшебник {((Wizard)(sender)).Name} " +
                              $"позвал. Моя цель {e.Message}");
            Location = e.Message;
        }
    }
}