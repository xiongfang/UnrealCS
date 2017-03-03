#pragma once

namespace UnrealEngine
{
	class _UBookMark
	{
		static UClass* StaticClass(){return UBookMark::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBookMark::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
