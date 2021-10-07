using System;
using System.Diagnostics;

namespace DelegatesPerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new Stopwatch();

            Console.WriteLine("Testing delegates performance");

            ts.Start();

            for (int i = 0; i < 1000; i++)
            {
                TestDelegate.UseDelegate();
            }

            ts.Stop();

            Console.WriteLine("Time taken: " + ts.ElapsedMilliseconds + " milliseconds");
        }
    }

    class TestDelegate
    {
        public delegate void Del();

        public static void TestDelegateMethod()
        {
            int a = 2;
            for (int i = 0; i < 100_000; i++)
            {
                a = 1;
            }
        }

        public static void UseDelegate()
        {

            Del del1 = TestDelegateMethod;

            del1();
        }
    }
}
