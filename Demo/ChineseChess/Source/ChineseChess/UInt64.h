#pragma once
#include "Object.h"
class Boolean;
class Int32;
	class UInt64:public Object
	{
		public:
		Boolean op_Equals(Int32  b);
		public:
		Boolean op_Small(Int32  b);
		public:
		Int32 op_Assign(Int32  b);
		public:
		Int32 op_PlusPlus(Int32  b);
	};
