#pragma once

namespace UnrealEngine
{
	class _ANavigationData
	{
		static UClass* StaticClass(){return ANavigationData::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavigationData::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
