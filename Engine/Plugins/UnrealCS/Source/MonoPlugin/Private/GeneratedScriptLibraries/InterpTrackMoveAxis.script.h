#pragma once

namespace UnrealEngine
{
	class _UInterpTrackMoveAxis
	{
		static UClass* StaticClass(){return UInterpTrackMoveAxis::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackMoveAxis::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
