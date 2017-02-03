#pragma once

namespace UnrealEngine
{
	class _UHapticFeedbackEffect_Curve
	{
		static UClass* StaticClass(){return UHapticFeedbackEffect_Curve::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHapticFeedbackEffect_Curve::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
