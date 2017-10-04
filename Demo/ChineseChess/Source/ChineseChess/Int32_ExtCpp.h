using namespace System;
System::Boolean Int32::op_Equals(System::Int32  b)
{
	return _v == b._v;
}

System::Boolean Int32::op_Small(System::Int32  b)
{
	return _v < b._v;
}
System::Int32 Int32::op_Assign(System::Int32  b)
{
	_v = b._v;
	return *this;
}
System::Int32 Int32::op_PlusPlus(System::Int32  b)
{
	_v++;
	return *this;
}