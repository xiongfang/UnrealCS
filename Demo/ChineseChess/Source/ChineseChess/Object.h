#pragma once
namespace System
{
class String;
}
namespace System
{
class Boolean;
}
namespace System{
	class Object	{
		public:
		virtual System::String* ToString();
		public:
		virtual System::Boolean Equals(System::Object*  v);
	};
}
