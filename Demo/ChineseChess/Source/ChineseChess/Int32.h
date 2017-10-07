#pragma once
#include "Object.h"
class Boolean;
	class Int32:public Object
	{
		public:
		static 		Int32 MaxValue;
		public:
		static 		Int32 MinValue;
		public:
		Boolean op_Equals(Int32  b);
		public:
		Boolean op_Small(Int32  b);
		public:
		Int32 op_Assign(Int32  b);
		public:
		Int32 op_PlusPlus(Int32  b);
	#include "Int32_ExtHeader.h"
	};
