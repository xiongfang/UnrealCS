#pragma once

namespace UnrealEngine
{
	class _APointLight
	{
		static UClass* StaticClass(){return APointLight::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.APointLight::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
