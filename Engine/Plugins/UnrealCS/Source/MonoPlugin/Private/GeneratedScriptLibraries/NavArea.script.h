#pragma once

namespace UnrealEngine
{
	class _UNavArea
	{
		static UClass* StaticClass(){return UNavArea::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavArea::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
