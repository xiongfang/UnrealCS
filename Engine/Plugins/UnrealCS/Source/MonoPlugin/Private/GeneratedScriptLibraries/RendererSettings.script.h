#pragma once

namespace UnrealEngine
{
	class _URendererSettings
	{
		static UClass* StaticClass(){return URendererSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URendererSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
