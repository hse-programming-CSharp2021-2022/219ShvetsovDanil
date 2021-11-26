using System;
using System.Text;

namespace Program
{
    class SnowMaiden : Person
    {
        public SnowMaiden(string name) : base(name) { }
        private string CreateName()
        {
            int len = random.Next(3, 11);
            StringBuilder str = new StringBuilder(len);
            for (int i = 0; i < len; i++)
                str[i] = (char)random.Next('a', 'z' + 1);
            return str.ToString();
        }
        public string[] CreatePresent(int amount)
        {
            string[] gifts = new string[amount];
            for (int i = 0; i < amount; i++)
            {
                gifts[i] = CreateName();
            }
            return gifts;
        }
        public override void Receive(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else
                throw new ArgumentException(">1 gifts");
        }
    }
}