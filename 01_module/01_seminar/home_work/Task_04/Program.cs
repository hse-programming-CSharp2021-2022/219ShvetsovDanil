using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R;
            
            Console.Write("Введите значение напряжения U: ");
            double.TryParse(Console.ReadLine(), out U);
            
            Console.Write("Введите значение сопротивления R: ");
            double.TryParse(Console.ReadLine(), out R);

            if (U != 0 & R != 0)
            {
                Console.WriteLine("\nВы ввели правильные значения!");
                Console.WriteLine("Сила тока равна = " + (U / R));
                Console.WriteLine("Потребляемая мощность равна = " + (U * U / R));
            }
            else
                Console.WriteLine("\nВозникла ошибка");
        }
    }
}