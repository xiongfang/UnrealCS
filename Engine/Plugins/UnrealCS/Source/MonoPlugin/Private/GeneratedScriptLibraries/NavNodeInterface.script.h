#pragma once

namespace UnrealEngine
{
	class _UNavNodeInterface
	{
		static UClass* StaticClass(){return UNavNodeInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UNavNodeInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
