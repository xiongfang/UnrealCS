#pragma once

namespace UnrealEngine
{
	class _UAnimationSettings
	{
		static UClass* StaticClass(){return UAnimationSettings::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimationSettings::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
