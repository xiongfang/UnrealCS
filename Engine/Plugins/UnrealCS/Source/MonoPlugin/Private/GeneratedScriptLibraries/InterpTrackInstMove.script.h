#pragma once

namespace UnrealEngine
{
	class _UInterpTrackInstMove
	{
		static UClass* StaticClass(){return UInterpTrackInstMove::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackInstMove::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
