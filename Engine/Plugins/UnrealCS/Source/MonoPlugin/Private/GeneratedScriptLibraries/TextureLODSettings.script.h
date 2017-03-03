#pragma once

namespace UnrealEngine
{
	class _UTextureLODSettings
	{
		static UClass* StaticClass(){return UTextureLODSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTextureLODSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
