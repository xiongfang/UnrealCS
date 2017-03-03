#pragma once

namespace UnrealEngine
{
	class _UHapticFeedbackEffect_Base
	{
		static UClass* StaticClass(){return UHapticFeedbackEffect_Base::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHapticFeedbackEffect_Base::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
