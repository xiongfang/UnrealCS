#pragma once

namespace UnrealEngine
{
	class _ULightmassPrimitiveSettingsObject
	{
		static UClass* StaticClass(){return ULightmassPrimitiveSettingsObject::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULightmassPrimitiveSettingsObject::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
