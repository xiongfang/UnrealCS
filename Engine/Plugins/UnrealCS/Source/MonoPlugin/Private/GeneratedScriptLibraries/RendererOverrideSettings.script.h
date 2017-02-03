#pragma once

namespace UnrealEngine
{
	class _URendererOverrideSettings
	{
		static UClass* StaticClass(){return URendererOverrideSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URendererOverrideSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
