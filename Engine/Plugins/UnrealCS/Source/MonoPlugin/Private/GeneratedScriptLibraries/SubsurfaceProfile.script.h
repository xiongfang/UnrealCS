#pragma once

namespace UnrealEngine
{
	class _USubsurfaceProfile
	{
		static UClass* StaticClass(){return USubsurfaceProfile::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USubsurfaceProfile::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
