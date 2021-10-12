using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_01 
{
    class Program 
    {
        static void PrintArray(int[] arr)
        {
            foreach (var str in arr)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args) 
        {
            string path = @"/Users/shvetsovdanil/Desktop/git_projects/01_module/11_seminar/class_work/Task_01/Data.txt";

            int n;
            do
            {
                Console.Write("Enter n number: ");
            } while (!int.TryParse(Console.ReadLine(), out n) && n < 0);
            
            var tmpDataArray = new string[n];
            var evenNumbersAmount = 0;
            var oddNumbersAmount = 0;
            // Создаем файл с данными
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            for (var i = 0; i < n; i++)
            {
                var str = new StringBuilder();
                for (var j = 0; j < 5; j++)
                {
                    var rnd = new Random();
                    var tmpNum = rnd.Next(10, 100);
                    if (tmpNum % 2 == 0)
                        evenNumbersAmount++;
                    else
                        oddNumbersAmount++;
                    str.Append(tmpNum + " ");
                }

                tmpDataArray[i] = str.ToString();
            }
            
            // PrintArray(tmpDataArray);
            File.WriteAllLines(path, tmpDataArray, Encoding.UTF8);

            // Open the file to read from
            if (File.Exists(path)) 
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] arr = StringArrayToIntArray(stringValues);
                // foreach(int i in arr)
                // {
                //     Console.Write(i + " ");
                // }

                var evenElIndArray = new int[evenNumbersAmount];
                var oddElIndArray = new int[oddNumbersAmount];

                evenNumbersAmount = 0;
                oddNumbersAmount = 0;
                
                for (var i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenElIndArray[evenNumbersAmount] = i;
                        evenNumbersAmount++;
                    }
                    else
                    {
                        oddElIndArray[oddNumbersAmount] = i;
                        oddNumbersAmount++;
                        arr[i] = 0;
                    }
                }
                
                PrintArray(evenElIndArray);
                PrintArray(oddElIndArray);
                PrintArray(arr);
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str) {
            int[] arr = null;
            if (str.Length != 0) {
                arr = new int[0];
                foreach (string s in str) {
                    int tmp;
                    if (int.TryParse(s, out tmp)) {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}