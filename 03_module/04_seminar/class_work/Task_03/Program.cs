using System;

namespace Task_03
{
    public delegate void NewStringValue(string s);
    
    public class UIStringEventArgs: EventArgs
    {
        public string Str { get; private set; }
        public UIStringEventArgs(string s) => Str = s;
    }
    
    public class UIString
    {
        public void NewStringValueHappenedHandler(object sender, UIStringEventArgs e) => str = e.Str;

        string str = "Default text";
        public string Str { get { return str; } private set { str = value; } }
    }
    
    class ConsoleUI
    {
        public event EventHandler<UIStringEventArgs> NewStringValueHappened;
        
        UIString s = new UIString(); // специальная строка
        public UIString S { get { return s; } set { s = value; } }
        public void GetStringFromUI()
        {
            Console.Write("Введите новое значение строки: ");
            string str = Console.ReadLine();
            NewStringValueHappened?.Invoke(this, new(str));
            RefreshUI();
        }
        public void CreateUI()
        {
            NewStringValueHappened += s.NewStringValueHappenedHandler;
            RefreshUI();
        }
        public void RefreshUI()
        {      // обновление строки
            Console.Clear();
            Console.WriteLine("Текст строки: " + s.Str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI c = new ConsoleUI();
            c.CreateUI(); // запускаем выполнение объекта класса ConsoleUI
            do
            {
                c.GetStringFromUI();  // изменяем значение строки
                Console.WriteLine("Чтобы закончить эксперименты, нажмите ESC...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}