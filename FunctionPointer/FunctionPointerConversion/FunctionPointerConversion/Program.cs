using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FunctionPointerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestUnsafe.TestRegularImplicit();
            //TestUnsafe.TestDifferentConvention();
            TestUnsafe.TestDifferentSpecificConvention();
        }
    }

    unsafe class TestUnsafe
    {
        public static int testFuncSimple(string s)
        {
            return s.Length;
        }

        [UnmanagedCallersOnly]
        public static int testFuncUnmanaged(int input)
        {
            return ++input;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int testFuncUnmanagedCdecl(int input)
        {
            return input++;
        }



        public static void TestRegularImplicit()
        {
            delegate*<string, int> a;
            delegate*<string, int> b;
            a = &testFuncSimple;
            b = a;
            int result = b("hello");
            Console.WriteLine("TestRegularImplicit result: " + result);
        }

        public static void TestDifferentConvention()
        {
            int input = 5;
            delegate* unmanaged<int, int> a;
            delegate*<ref int, int> b;
            delegate* unmanaged<ref int, int> c;
            delegate* unmanaged<int, int> d;
            //a = &testFunc;
            a = &testFuncUnmanaged;
            //b = a;
            c = (delegate* unmanaged<ref int, int>)a;
            d = a;
            int result = d(input);
            c(ref input);
            Console.WriteLine("TestDifferentConvention result: " + result);
            Console.WriteLine("TestDifferentConvention ref passed value: " + input);
        }

        public static void TestDifferentSpecificConvention()
        {
            delegate* unmanaged[Cdecl]<int, int> a;
            delegate* unmanaged<int, int> b;

            a = &testFuncUnmanagedCdecl;
            //b = a;
            int result = a(5);
            Console.WriteLine("TestDifferentSpecificConvention result: " + result);
        }
    }
}
