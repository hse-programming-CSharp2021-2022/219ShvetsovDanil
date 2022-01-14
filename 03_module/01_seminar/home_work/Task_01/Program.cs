using System;

namespace Task_01
{
    class Program
    {
        delegate int Cast(double n);
        
        static void Main(string[] args)
        {
            // Anonymous method which counts closest even number.
            Cast anonym1 = delegate(double n)
            {
                return Math.Floor(n) % 2 == 0 ? (int) n : (int) (n + 1);
            };
            // Tests.
            Console.WriteLine(anonym1(6.4)); // 6
            Console.WriteLine(anonym1(6.7)); // 6
            Console.WriteLine(anonym1(7.4)); // 8
            Console.WriteLine(anonym1(7.8)); // 8
            Console.WriteLine();
            
            // Anonymous method which counts degree of positive number.
            Cast anonym2 = delegate(double d)
            {
                var degree = 0;
                
                if (d < 1)
                    return -1;
                
                while (d > 10)
                {
                    degree += 1;
                    d /= 10;
                }

                return degree;
            };
            // Tests.
            Console.WriteLine(anonym2(0.5)); // -1
            Console.WriteLine(anonym2(7.7)); // 0
            Console.WriteLine(anonym2(25.8)); // 1
            Console.WriteLine(anonym2(12345.68)); // 4
            Console.WriteLine();

            Cast multiCast = anonym1;
            multiCast += anonym2;
            Console.WriteLine(multiCast(56.8)); // 1 => prints output and action of last added method.
            Console.WriteLine();
            
            // Lambda-expression of 1st anonymous method.
            Cast lambda1 = n => Math.Floor(n) % 2 == 0 ? (int) n : (int) (n + 1);
            // Tests.
            Console.WriteLine(anonym1(6.4)); // 6
            Console.WriteLine(anonym1(6.7)); // 6
            Console.WriteLine(anonym1(7.4)); // 8
            Console.WriteLine(anonym1(7.8)); // 8
            Console.WriteLine();
            
            // Lambda-expression of 2nd anonymous method.
            Cast lambda2 = d => d < 1 ? -1 : ((int) d).ToString().Length - 1;
            Console.WriteLine(anonym2(0.5)); // -1
            Console.WriteLine(anonym2(7.7)); // 0
            Console.WriteLine(anonym2(25.8)); // 1
            Console.WriteLine(anonym2(12345.68)); // 4
            Console.WriteLine();
            
            // Using of Invoke-method.
            Console.WriteLine(anonym2.Invoke(564543.76)); // 5
            Console.WriteLine();

            multiCast += lambda1;
            multiCast += lambda2;
            // Deleting of first added lambda-expression.
            multiCast -= lambda1;
            foreach (var del in multiCast.GetInvocationList())
            {
                Console.WriteLine(del.Method.Name);
            }
            Console.WriteLine();

            // Deleting of anonymous first added method.
            multiCast -= anonym1;
            foreach (var del in multiCast.GetInvocationList())
            {
                Console.WriteLine(del.Method.Name);
            }
            Console.WriteLine();
        }
    }
}