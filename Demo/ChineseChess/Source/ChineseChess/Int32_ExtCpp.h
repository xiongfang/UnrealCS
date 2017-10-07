//namespace System
//{
	Boolean Int32::op_Equals(Int32  b)
	{
		return _v == b._v;
	}

	Boolean Int32::op_Small(Int32  b)
	{
		return _v < b._v;
	}
	Int32 Int32::op_Assign(Int32  b)
	{
		_v = b._v;
		return *this;
	}
	Int32 Int32::op_PlusPlus(Int32  b)
	{
		_v++;
		return *this;
	}
//}
