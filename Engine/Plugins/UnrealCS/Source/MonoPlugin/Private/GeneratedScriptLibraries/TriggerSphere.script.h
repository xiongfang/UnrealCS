#pragma once

namespace UnrealEngine
{
	class _ATriggerSphere
	{
		static UClass* StaticClass(){return ATriggerSphere::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ATriggerSphere::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
