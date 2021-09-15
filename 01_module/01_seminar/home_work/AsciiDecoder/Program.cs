using System;

namespace AsciiDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFromUser;
            Console.Write("Введите целое число из диапазона от 32 до 127: ");
            int.TryParse(Console.ReadLine(), out numFromUser);
            
            Console.WriteLine($"Ваш символ из таблицы ASCII: {(char)numFromUser}");
        }
    }
}