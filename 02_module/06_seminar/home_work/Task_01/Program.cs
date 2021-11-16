using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        private static void PrintIntegerNumber()
        {
            Console.Write("Enter integer number n: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your number = {n}");
            }
            catch (FormatException formatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {formatException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintArrayElement()
        {
            Console.Write("Enter index i of array's element: ");
            int.TryParse(Console.ReadLine(), out int i);
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            try
            {
                Console.WriteLine($"Your element = {array[i]}");
            }
            catch (IndexOutOfRangeException indexOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {indexOutOfRangeException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintDivisionResult()
        {
            Console.Write("Enter number n1: ");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.Write("Enter number n2: ");
            int.TryParse(Console.ReadLine(), out int n2);
            try
            {
                Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {divideByZeroException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintSumTwoNumbers()
        {
            Console.Write("Enter number n1: ");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.Write("Enter number n2: ");
            int.TryParse(Console.ReadLine(), out int n2);
            try
            {
                int total = checked(n1 + n2);
                Console.WriteLine($"{n1} + {n2} = {total}");
            }
            catch (OverflowException overflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {overflowException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            
        }

        private static void PrintDoubleNumber()
        {
            object n = 5;
            try
            {
                Console.WriteLine($"Double value of {n} = {(double) n}");
            }
            catch (InvalidCastException invalidCastException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {invalidCastException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintFirstLineOfFile()
        {
            string path = "abcdef<>:*?....";
            try
            {
                string firstLine = File.ReadAllLines(path)[0];
                Console.WriteLine($"First line of {Path.GetFileName(path)} = {firstLine}");
            }
            catch (ArgumentException argumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {argumentException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintDirectoryFoldersAndFiles()
        {
            string path = "abcdef";
            try
            {
                string[] data = Directory.GetFileSystemEntries(path);
                foreach (var s in data)
                {
                    Console.WriteLine(s);
                }
            }
            catch (DirectoryNotFoundException directoryNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {directoryNotFoundException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void WriteLineInFile()
        {
            string path = "anyPathToDeniedFile";
            string line = "hello world!";
            try
            {
                File.WriteAllText(path, line);
                Console.WriteLine("Text is successfully written!");
            }
            catch (UnauthorizedAccessException iUnauthorizedAccessException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {iUnauthorizedAccessException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintArrayData()
        {
            int[] numbers = null;
            try
            {
                for (var i = 1; i <= 10; i++)
                {
                    numbers[i] = i * i;
                }

                foreach (var num in numbers)
                {
                    Console.Write(num + " ");
                }
            }
            catch (NullReferenceException nullReferenceException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {nullReferenceException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintAnimals()
        {
            string[] animals = {"Dog", "Cat", "Fox", "Wolf", "Sheep"};
            Object[] objects = (Object[]) animals;
            try
            {
                objects[3] = 5;
                foreach (var animal in objects)
                {
                    Console.Write(animal + " ");
                }
            }
            catch (ArrayTypeMismatchException arrayTypeMismatchException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {arrayTypeMismatchException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintPositiveNumber()
        {
            Console.Write("Enter a positive number: ");
            int.TryParse(Console.ReadLine(), out int n);
            try
            {
                if (n >= 0)
                {
                    Console.WriteLine($"Your number = {n}");
                }
                else
                {
                    throw new MyNegativeNumberException();
                }
            }
            catch (MyNegativeNumberException negativeNumberException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {negativeNumberException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private static void PrintPrimeNumber()
        {
            Console.Write("Enter a prime number: ");
            int.TryParse(Console.ReadLine(), out int n);
            try
            {
                for (var i = 2; i < Math.Sqrt(n) + 1; i++)
                {
                    if (n % i == 0)
                    {
                        throw new MyNotPrimeNumberException();
                    }
                }
                Console.WriteLine($"Your prime number = {n}");
            }
            catch (MyNotPrimeNumberException notPrimeNumberException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {notPrimeNumberException.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Occured an error! {exception.Message}");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            
            // FormatException
            Console.WriteLine("Case: FormatException");
            PrintIntegerNumber();
            Console.WriteLine();
            
            // IndexOutOfRangeException
            Console.WriteLine("Case: IndexOutOfRangeException");
            PrintArrayElement();
            Console.WriteLine();
            
            // DivideByZeroException
            Console.WriteLine("Case: DivideByZeroException");
            PrintDivisionResult();
            Console.WriteLine();
            
            // OverflowException
            Console.WriteLine("Case: OverflowException");
            PrintSumTwoNumbers();
            Console.WriteLine();
            
            // InvalidCastException
            Console.WriteLine("Case: InvalidCastException");
            PrintDoubleNumber();
            Console.WriteLine();
            
            // ArgumentException
            Console.WriteLine("Case: ArgumentException");
            PrintFirstLineOfFile();
            Console.WriteLine();
            
            // DirectoryNotFoundException
            Console.WriteLine("Case: DirectoryNotFoundException");
            PrintDirectoryFoldersAndFiles();
            Console.WriteLine();
            
            // UnauthorizedAccessException
            Console.WriteLine("Case: UnauthorizedAccessException");
            WriteLineInFile();
            Console.WriteLine();
            
            // NullReferenceException
            Console.WriteLine("Case: NullReferenceException");
            PrintArrayData();
            Console.WriteLine();
            
            // ArrayTypeMismatchException
            Console.WriteLine("Case: ArrayTypeMismatchException");
            PrintAnimals();
            Console.WriteLine();
            
            // MyNegativeNumberException
            Console.WriteLine("Case: MyNegativeNumberException");
            PrintPositiveNumber();
            Console.WriteLine();
            
            // MyNotPrimeNumberException
            Console.WriteLine("Case: MyNotPrimeNumberException");
            PrintPrimeNumber();
            Console.WriteLine();
        }
    }
}