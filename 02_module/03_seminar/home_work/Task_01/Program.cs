using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_01
{
    class Program
    {
        private static string GetName()
        {
            var nameLength = new Random().Next(2, 10);
            var name = new StringBuilder(nameLength);

            var intLatinLetterInAscii = new List<int>();
            for (var i = 65; i <= 90; i++)
            {
                intLatinLetterInAscii.Add(i);
            }
            for (var i = 97; i <= 122; i++)
            {
                intLatinLetterInAscii.Add(i);
            }
            
            for (var i = 0; i < nameLength; i++)
            {
                name.Append((char) intLatinLetterInAscii[new Random().Next(0, intLatinLetterInAscii.Count - 1)]);
            }

            return name.ToString();
        }
        
        private static int GetDuration() => new Random().Next(60, 361);

        private static int GetQuality() => new Random().Next(100, 1001);
        
        static void Main(string[] args)
        {
            do
            {
                VideoFile example = new("Example", 300, 720);
                Console.WriteLine("Имеется исходный видеофайл.");
                Console.WriteLine(example.GetInfo());
                Console.WriteLine();


                var numberOfFiles = new Random().Next(5, 16);
                Console.WriteLine($"Количество новых видеофайлов, которые будут созданы = {numberOfFiles}.");

                VideoFile[] generatedArrayOfVideoFile = new VideoFile[numberOfFiles];
                for (var i = 0; i < numberOfFiles; i++)
                {
                    generatedArrayOfVideoFile[i] = new VideoFile(GetName(), GetDuration(), GetQuality());
                }

                Console.WriteLine("Создание новых видеофайлов");
                Console.ForegroundColor = ConsoleColor.Red;
                for (var i = 3; i > 0; i--)
                {
                    Console.WriteLine($"Осталось {i} сек...");
                    Thread.Sleep(1000);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Новые видеофайлы успешно созданы!\n");
                Console.ResetColor();
                
                Console.WriteLine(
                    "Выведем на экран информацию о файлах, размер которых больше размера исходного видеофайла.");
                var amountOfSuitableFiles = 0;
                foreach (VideoFile videoFile in generatedArrayOfVideoFile)
                {
                    if (videoFile.Size > example.Size)
                    {
                        Console.WriteLine(videoFile.GetInfo() + "\n");
                        amountOfSuitableFiles++;
                    }
                }
                Console.WriteLine($"Количество подходящих файлов = {amountOfSuitableFiles}!\n");

                Exit:
                Console.WriteLine("Нажмите \"ENTER\", чтобы повторить действия. Нажмите \"BACKSPACE\", чтобы выйти " +
                                  "из программы.");
                ConsoleKeyInfo keyToExit = Console.ReadKey();
                Console.WriteLine();
                
                if (keyToExit.Key == ConsoleKey.Enter)
                    continue;
                else if (keyToExit.Key == ConsoleKey.Backspace)
                    break;
                else
                {
                    Console.WriteLine("Вы нажали неверную кнопку! Повторите действие!\n");
                    goto Exit;
                }
            } while (true);
            
            Console.WriteLine("Благодарю за использование программы!");
        }
    }
}