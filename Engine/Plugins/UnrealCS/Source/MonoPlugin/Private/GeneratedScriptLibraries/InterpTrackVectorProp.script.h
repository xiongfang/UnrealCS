#pragma once

namespace UnrealEngine
{
	class _UInterpTrackVectorProp
	{
		static UClass* StaticClass(){return UInterpTrackVectorProp::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackVectorProp::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
