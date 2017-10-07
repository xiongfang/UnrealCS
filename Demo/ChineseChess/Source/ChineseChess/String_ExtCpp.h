//using namespace System;
System::String::String(const char* c)
{ 
	int len = strlen(c) + 1;
	_v = new char[len];
	sprintf_s(_v, len, "%s", c);
}