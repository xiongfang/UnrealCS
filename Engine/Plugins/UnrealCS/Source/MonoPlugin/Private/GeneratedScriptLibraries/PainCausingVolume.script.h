#pragma once

namespace UnrealEngine
{
	class _APainCausingVolume
	{
		static UClass* StaticClass(){return APainCausingVolume::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APainCausingVolume::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
