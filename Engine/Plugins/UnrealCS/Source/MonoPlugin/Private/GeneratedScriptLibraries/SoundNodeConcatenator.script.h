#pragma once

namespace UnrealEngine
{
	class _USoundNodeConcatenator
	{
		static UClass* StaticClass(){return USoundNodeConcatenator::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USoundNodeConcatenator::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
