#pragma once
#include "Object.h"
namespace System
{
class Boolean;
}
namespace System
{
class Int32;
}
namespace System{
	class UInt64:public System::Object
	{
		public:
		System::Boolean op_Equals(System::Int32  b);
		public:
		System::Boolean op_Small(System::Int32  b);
		public:
		System::Int32 op_Assign(System::Int32  b);
		public:
		System::Int32 op_PlusPlus(System::Int32  b);
	};
}
