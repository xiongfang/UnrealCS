#pragma once

namespace UnrealEngine
{
	class _UCommandlet
	{
		static UClass* StaticClass(){return UCommandlet::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCommandlet::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
