using System;

namespace Task_01
{
    public sealed class Wizard : Creature
    {
        public override string Name { get; set; }

        public override string Location { get; set; }

        public override void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e) { }

        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e);

        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;

        public Wizard(string name, string location) => (Name, Location) = (name, location);

        public Wizard() { }

        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл!");
            RaiseRingIsFoundEvent(this, new("Ривендейл"));
        }
    }
}