#pragma once

namespace UnrealEngine
{
	class _UInterpTrackInstAnimControl
	{
		static UClass* StaticClass(){return UInterpTrackInstAnimControl::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackInstAnimControl::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
