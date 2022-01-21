namespace Task_01
{
    public abstract class Creature
    { 
        public abstract string Name { get; set; }

        public abstract string Location { get; set; }
        
        public abstract void RingIsFoundEventHandle(object sender, RingIsFoundEventArgs e);
    }
}