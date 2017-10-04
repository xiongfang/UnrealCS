using namespace System;
String* Object::ToString()
{
	
	void* v = (void*)this;
	char str[32];

	sprintf_s(str,32, "%x", v);

	return new String(str);
}


Boolean Object::Equals(System::Object*  v)
{
	return v == this;
}