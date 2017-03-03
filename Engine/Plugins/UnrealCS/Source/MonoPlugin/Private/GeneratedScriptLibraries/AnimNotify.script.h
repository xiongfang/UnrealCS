#pragma once

namespace UnrealEngine
{
	class _UAnimNotify
	{
		static UClass* StaticClass(){return UAnimNotify::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimNotify::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
