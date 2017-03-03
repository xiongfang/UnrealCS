#pragma once

namespace UnrealEngine
{
	class _UNavRelevantInterface
	{
		static UClass* StaticClass(){return UNavRelevantInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavRelevantInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
