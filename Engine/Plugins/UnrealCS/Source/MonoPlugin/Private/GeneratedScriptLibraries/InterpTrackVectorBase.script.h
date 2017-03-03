#pragma once

namespace UnrealEngine
{
	class _UInterpTrackVectorBase
	{
		static UClass* StaticClass(){return UInterpTrackVectorBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackVectorBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
