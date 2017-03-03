#pragma once

namespace UnrealEngine
{
	class _UTextureLightProfile
	{
		static UClass* StaticClass(){return UTextureLightProfile::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextureLightProfile::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
