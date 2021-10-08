#include "WishList.h"

#include <iostream>

static const wchar_t* GetHelloString() {
	return L"Items: Pen, Paper, Laptop, Boots";
}

typedef const wchar_t* (*helloStrPtr)(void);


extern "C" __declspec(dllexport) void GetFuncPtr(helloStrPtr * outFuncPtr) {
	*outFuncPtr = &GetHelloString;
}