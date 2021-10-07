using System;
using System.Diagnostics;

namespace ConsoleApp3
{
    class Program
    {
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            var ts = new Stopwatch();

            ts.Start();

            //for (long i = 0; i < 10_000; i++)
            //{
            //    Util.Use();
            //}

            for (long i = 0; i < 10_000; i++)
            {

                Del del1 = SayHello;

                del1 += TestHello;

                del1("geag");
            }


            ts.Stop();

            Console.WriteLine("Time taken: " + ts.ElapsedMilliseconds + " milliseconds");

            //Del del1 = SayHello;

            //del1 += TestHello;

            //del1("geag");
        }

        static void SayHello(string msg)
        {
            Console.WriteLine("Say: " + msg);
        }

        static void TestHello(string msg)
        {
            Console.WriteLine("hello");
        }
    }

    unsafe class Util
    {
        public static void Log() { Console.WriteLine("Log simple"); }
        public static void Log(string p1) { Console.WriteLine("Log p1: " + p1); }
        public static void OtherLog(string p1) { Console.WriteLine(p1); }
        public static void Log(int i) { }

        public static void Use()
        {
            delegate*<void> a1 = &Log; // Log()
            a1();
            delegate*<string, void> a2 = &Log; // Log(int i)
            a2("hello");
            
            

            // Error: ambiguous conversion from method group Log to "void*"
            //void* v = &Log;
        }
    }
}
