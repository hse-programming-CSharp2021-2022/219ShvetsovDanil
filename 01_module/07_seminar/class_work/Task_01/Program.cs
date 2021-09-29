using System;
 
class Program {
    public static void Print(int[] mas)
    {
        foreach (var i in mas)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    static void Main() {
        int n = 10;
 
        int[] mas = new int[n];
        Random random = new Random();
 
        for (int i = 0; i < mas.Length; i++)
            mas[i] = random.Next(-20, 20);
 
        int max = mas[0];
        for (int i = 1; i < mas.Length; i++)
            if (mas[i] > max)
                max = mas[i];
        Console.WriteLine(max + "\n");
        Array.Sort(mas);
        Print(mas);
        Array.Sort(mas, CompareArray);
        Print(mas);
        Array.Sort(mas,
            (int a, int b) =>
            {
                a = Math.Abs(a); b = Math.Abs(b);
                if (a % 2 == 1 && b % 2 == 0) return 1;
                if (a % 2 == 0 && b % 2 == 1) return -1;
                return 0;
            }
        );
        Print(mas);
 
        for (int i = 0; i < mas.Length; i++)
            mas[i] = random.Next(-11, 11);
        Print(mas);
        Array.Reverse(mas);
        Print(mas);
        Console.WriteLine(Array.IndexOf(mas, 10));
        Array.Resize(ref mas, 2 * n);
        Print(mas);
        Console.WriteLine(Array.Exists(mas, (x) => x == 10));
        Console.WriteLine(Array.Find(mas, x => x % 3 == 0));
        int[] all = Array.FindAll(mas, x => x % 3 == 0);
        Print(all);
        Array.Clear(mas, 0, mas.Length);
        Print(mas);
        for (int i = 0; i < mas.Length; i++)
            mas[i] = random.Next(-11, 11);
        int[] copy = new int[30];
        Array.Copy(mas, copy, 20);
        Print(copy);
        Array.Sort(mas);
        Print(mas);
        Console.WriteLine(Array.BinarySearch(mas, 5));
    }
 
    public static int CompareArray(int a, int b)
    {
        if (a < b) return 1; // порядок нарушен, меняем
        if (a > b) return -1; // не нарушен, не меняем
        return 0;
    }
}