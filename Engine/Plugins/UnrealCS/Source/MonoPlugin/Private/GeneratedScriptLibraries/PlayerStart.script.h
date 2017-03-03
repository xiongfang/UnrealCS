#pragma once

namespace UnrealEngine
{
	class _APlayerStart
	{
		static UClass* StaticClass(){return APlayerStart::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APlayerStart::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
