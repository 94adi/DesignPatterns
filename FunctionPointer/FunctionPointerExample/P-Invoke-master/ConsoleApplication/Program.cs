using ConsoleApplication.Models;
using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
                delegate* unmanaged<char*> getHelloStrFuncPtr;
                WishList.GetFuncPtr(&getHelloStrFuncPtr);
                Console.WriteLine(new String(getHelloStrFuncPtr()));
                Console.ReadLine();
        }
    }
}
