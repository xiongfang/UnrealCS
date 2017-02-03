#pragma once

namespace UnrealEngine
{
	class _UNavArea_LowHeight
	{
		static UClass* StaticClass(){return UNavArea_LowHeight::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavArea_LowHeight::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
