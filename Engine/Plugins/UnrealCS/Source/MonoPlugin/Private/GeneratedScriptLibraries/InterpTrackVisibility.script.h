#pragma once

namespace UnrealEngine
{
	class _UInterpTrackVisibility
	{
		static UClass* StaticClass(){return UInterpTrackVisibility::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackVisibility::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
