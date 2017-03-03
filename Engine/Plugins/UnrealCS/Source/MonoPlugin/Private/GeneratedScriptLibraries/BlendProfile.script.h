#pragma once

namespace UnrealEngine
{
	class _UBlendProfile
	{
		static UClass* StaticClass(){return UBlendProfile::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlendProfile::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
