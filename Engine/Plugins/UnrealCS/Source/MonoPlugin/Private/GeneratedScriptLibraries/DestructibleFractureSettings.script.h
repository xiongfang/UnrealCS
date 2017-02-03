#pragma once

namespace UnrealEngine
{
	class _UDestructibleFractureSettings
	{
		static UClass* StaticClass(){return UDestructibleFractureSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDestructibleFractureSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
