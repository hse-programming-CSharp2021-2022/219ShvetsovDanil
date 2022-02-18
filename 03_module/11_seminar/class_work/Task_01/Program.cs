using System;
using System.IO;
using System.Text;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = new FileStream("task1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                if (fileStream.Length == 0)
                {
                    var line = "A";
                    var array = Encoding.Default.GetBytes(line);
                    
                    fileStream.Write(array, 0, array.Length);
                }
                else
                {
                    var array = new byte[fileStream.Length];
                    fileStream.Read(array, 0, array.Length);
                    var str = Encoding.Default.GetString(array);
                    Console.WriteLine(str);
                    if (str[^1] == 'C')
                    {
                        return;
                    }
                    var newString = ((char)(str[^1] + 1)).ToString();
                    var array2 = Encoding.Default.GetBytes(newString);
                    fileStream.Position = array.Length;
                    fileStream.Write(array2, 0, 1);
                }
            }
        }
    }
}