#pragma once

namespace UnrealEngine
{
	class _ADirectionalLight
	{
		static UClass* StaticClass(){return ADirectionalLight::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ADirectionalLight::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
