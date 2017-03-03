#pragma once

namespace UnrealEngine
{
	class _UInterpTrackInstDirector
	{
		static UClass* StaticClass(){return UInterpTrackInstDirector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackInstDirector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
