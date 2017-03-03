#pragma once

namespace UnrealEngine
{
	class _APlayerStartPIE
	{
		static UClass* StaticClass(){return APlayerStartPIE::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APlayerStartPIE::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
