#pragma once

namespace UnrealEngine
{
	class _UPhysicsSettings
	{
		static UClass* StaticClass(){return UPhysicsSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
