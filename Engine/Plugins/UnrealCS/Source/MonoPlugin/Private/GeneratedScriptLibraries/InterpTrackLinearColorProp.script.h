#pragma once

namespace UnrealEngine
{
	class _UInterpTrackLinearColorProp
	{
		static UClass* StaticClass(){return UInterpTrackLinearColorProp::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UInterpTrackLinearColorProp::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
