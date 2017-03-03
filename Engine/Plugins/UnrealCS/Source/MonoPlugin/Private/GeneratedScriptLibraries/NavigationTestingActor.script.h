#pragma once

namespace UnrealEngine
{
	class _ANavigationTestingActor
	{
		static UClass* StaticClass(){return ANavigationTestingActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavigationTestingActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
