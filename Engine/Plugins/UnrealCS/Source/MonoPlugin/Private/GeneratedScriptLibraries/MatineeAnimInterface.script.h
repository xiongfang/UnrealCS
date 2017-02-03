#pragma once

namespace UnrealEngine
{
	class _UMatineeAnimInterface
	{
		static UClass* StaticClass(){return UMatineeAnimInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMatineeAnimInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
