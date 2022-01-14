using System;

namespace Task_02
{
    delegate int MyDel(int n1, int n2);
    
    static class TestClass
    {
        public static int TestMethod(int n1, int n2) => n1 > n2 ? n1 : n2;
    }

    class TestClass2
    {
        public int TestMethod(int n1, int n2) => n1 + n2;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1.
            MyDel myDel1 = TestClass.TestMethod;
            Console.WriteLine(myDel1(10, 15));

            // Test 2.
            TestClass2 testClass2 = new();
            MyDel myDel2 = testClass2.TestMethod;
            Console.WriteLine(myDel2?.Invoke(10, 15));

            MyDel[] myDels = 
            {
                TestClass.TestMethod,
                testClass2.TestMethod
            };

            foreach (var myDel in myDels)
            {
                Console.WriteLine(myDel.Invoke(10, 20));
            }
        }
    }
}