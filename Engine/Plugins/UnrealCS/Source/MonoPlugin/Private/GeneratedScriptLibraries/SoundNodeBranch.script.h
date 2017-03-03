#pragma once

namespace UnrealEngine
{
	class _USoundNodeBranch
	{
		static UClass* StaticClass(){return USoundNodeBranch::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeBranch::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
