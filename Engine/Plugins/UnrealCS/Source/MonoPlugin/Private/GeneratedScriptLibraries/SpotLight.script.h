#pragma once

namespace UnrealEngine
{
	class _ASpotLight
	{
		static UClass* StaticClass(){return ASpotLight::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ASpotLight::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
