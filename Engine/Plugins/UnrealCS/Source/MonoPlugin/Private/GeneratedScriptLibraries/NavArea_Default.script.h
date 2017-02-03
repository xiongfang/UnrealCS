#pragma once

namespace UnrealEngine
{
	class _UNavArea_Default
	{
		static UClass* StaticClass(){return UNavArea_Default::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavArea_Default::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
