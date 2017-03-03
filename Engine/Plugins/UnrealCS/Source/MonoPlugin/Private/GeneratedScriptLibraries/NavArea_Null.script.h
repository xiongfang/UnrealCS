#pragma once

namespace UnrealEngine
{
	class _UNavArea_Null
	{
		static UClass* StaticClass(){return UNavArea_Null::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavArea_Null::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
