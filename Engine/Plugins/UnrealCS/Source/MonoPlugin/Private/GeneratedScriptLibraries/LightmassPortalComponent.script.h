#pragma once

namespace UnrealEngine
{
	class _ULightmassPortalComponent
	{
		static UClass* StaticClass(){return ULightmassPortalComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULightmassPortalComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
