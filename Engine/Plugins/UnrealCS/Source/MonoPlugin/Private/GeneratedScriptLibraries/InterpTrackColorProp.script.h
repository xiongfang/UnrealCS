#pragma once

namespace UnrealEngine
{
	class _UInterpTrackColorProp
	{
		static UClass* StaticClass(){return UInterpTrackColorProp::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackColorProp::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
