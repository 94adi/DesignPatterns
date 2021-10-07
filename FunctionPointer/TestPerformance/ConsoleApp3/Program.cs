using System;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new Stopwatch();

            Console.WriteLine("Testing function pointers performance");

            ts.Start();

            for (int i = 0; i < 10_000; i++)
            {
                PerformanceTest.UseFunctionPointer();
            }

            ts.Stop();

            Console.WriteLine("Time taken: " + ts.ElapsedMilliseconds + " milliseconds");



            Console.WriteLine("Testing delegates performance");

            ts.Start();

            for (int i = 0; i < 10_000; i++)
            {
                PerformanceTest.UseDelegate();

            }

            ts.Stop();

            Console.WriteLine("Time taken: " + ts.ElapsedMilliseconds + " milliseconds");

        }

    }

    unsafe class PerformanceTest
    {
        public delegate void Del();

        public static void Log() 
        { 
            int a = 2; 
            for (int i = 0; i < 1_000; i++) 
            { 
                a = 1; 
            } 
        }
        public static void Log(string p1) { Console.WriteLine("Log p1: " + p1); }
        public static void OtherLog(string p1) { Console.WriteLine(p1); }
        public static void Log(int i) { }

        public static void SayHello()
        {
            int a = 2; 
            for (int i = 0; i < 1_000; i++) 
            { 
                a = 1; 
            }
        }

        //public static void TestHello(string msg)
        //{
        //    int a = 2; 
        //    for (int i = 0; i < 1_000_000; i++) 
        //    { 
        //        a = 1; 
        //    }
        //}

        public static void UseFunctionPointer()
        {
            delegate*<void> a1 = &Log; // Log()
            a1();
            //delegate*<string, void> a2 = &Log; // Log(int i)
            //a2("hello");
        }

        public static void UseDelegate()
        {

            Del del1 = SayHello;
            //del1 += TestHello;

            del1();
        }

    }

}

