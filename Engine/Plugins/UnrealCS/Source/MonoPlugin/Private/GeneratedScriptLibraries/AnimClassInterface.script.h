#pragma once

namespace UnrealEngine
{
	class _UAnimClassInterface
	{
		static UClass* StaticClass(){return UAnimClassInterface::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimClassInterface::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
