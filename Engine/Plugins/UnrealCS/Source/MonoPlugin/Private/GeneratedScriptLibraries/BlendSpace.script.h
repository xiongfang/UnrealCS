#pragma once

namespace UnrealEngine
{
	class _UBlendSpace
	{
		static UClass* StaticClass(){return UBlendSpace::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlendSpace::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
