#pragma once

namespace UnrealEngine
{
	class _UInterpTrackDirector
	{
		static UClass* StaticClass(){return UInterpTrackDirector::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackDirector::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
