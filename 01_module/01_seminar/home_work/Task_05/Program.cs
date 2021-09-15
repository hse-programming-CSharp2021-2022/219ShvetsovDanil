using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int cath1, cath2;
            
            Console.Write("Введите значение первого катета: ");
            int.TryParse(Console.ReadLine(), out cath1);
            
            Console.Write("Введите значение второго катета: ");
            int.TryParse(Console.ReadLine(), out cath2);

            if (cath1 != 0 & cath2 != 0)
            {
                Console.WriteLine("\nВведенные данные корректны!");
                Console.WriteLine("Значение гипотенузы равно: " + Math.Sqrt((cath1 * cath1 + cath2 * cath2)));
            }
            else
                Console.WriteLine("\nВведенные данные некорректны! Ошбика!");
        }
    }
}