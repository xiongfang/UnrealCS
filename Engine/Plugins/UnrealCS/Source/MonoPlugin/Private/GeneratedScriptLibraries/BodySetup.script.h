#pragma once

namespace UnrealEngine
{
	class _UBodySetup
	{
		static UClass* StaticClass(){return UBodySetup::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBodySetup::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
