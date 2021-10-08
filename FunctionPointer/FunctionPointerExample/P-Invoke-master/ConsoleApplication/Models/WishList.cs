using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication.Models
{
    public class WishList
    {
        [DllImport("NativeLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void GetFuncPtr(delegate* unmanaged<char*>* outFuncPtr);   
    }
}
