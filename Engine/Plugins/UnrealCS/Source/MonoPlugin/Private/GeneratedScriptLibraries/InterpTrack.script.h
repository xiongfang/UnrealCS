#pragma once

namespace UnrealEngine
{
	class _UInterpTrack
	{
		static UClass* StaticClass(){return UInterpTrack::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrack::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
