
Int32 FInt32::ToInt32(FInt32  v)
{
	return v._v;
}

FInt32 FInt32::FromInt32(Int32  v)
{
	_v = v._v;
	return *this;
}