using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FuncPtrTargetMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.Use();
        }
    }

    unsafe static class Util
    {
        public static void Log() { Console.WriteLine("void Log() was called"); }
        public static void Log(string p1) { Console.WriteLine("void Log(string p1) was called"); }
        public static void Log(int i) { Console.WriteLine("void Log(int i) was called"); }

        public static void Use()
        {
            delegate*<void> a1 = &Log; // Log()
            delegate*<int, void> a2 = &Log; // Log(int i)
            delegate*<string, void> a3 = &Log; //Log(string p1)

            a1();
            a2(1);
            a3("a");

            // Error: ambiguous conversion from method group Log to "void*"
            // void* is a pointer to UNKNOWN type
            //void* v = &Log;
        }
    }
}
