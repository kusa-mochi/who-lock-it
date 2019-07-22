#pragma once
#include <Windows.h>
#include <Psapi.h>
#include <stdio.h>
#include <tchar.h>

using namespace System;

namespace ProcessManagerCLR {
	public ref class ProcessFinderCLR
	{
		// TODO: このクラスのメソッドをここに追加します。
	public:
		int FuncA();

	private:
		void PrintProcessNameAndID(DWORD processID);
	};
}
