//namespace System
//{
	String* Object::ToString()
	{

		void* v = (void*)this;
		char str[64];

		sprintf_s(str, 64, "%llx", (long long)v);

		return new String(str);
	}


	Boolean Object::Equals(Object*  v)
	{
		return v == this;
	}
//}
