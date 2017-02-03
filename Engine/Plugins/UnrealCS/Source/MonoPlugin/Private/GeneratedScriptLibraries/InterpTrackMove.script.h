#pragma once

namespace UnrealEngine
{
	class _UInterpTrackMove
	{
		static UClass* StaticClass(){return UInterpTrackMove::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackMove::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
