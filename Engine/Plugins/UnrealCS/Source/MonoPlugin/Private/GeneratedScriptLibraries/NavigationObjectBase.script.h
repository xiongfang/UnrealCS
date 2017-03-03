#pragma once

namespace UnrealEngine
{
	class _ANavigationObjectBase
	{
		static UClass* StaticClass(){return ANavigationObjectBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ANavigationObjectBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
