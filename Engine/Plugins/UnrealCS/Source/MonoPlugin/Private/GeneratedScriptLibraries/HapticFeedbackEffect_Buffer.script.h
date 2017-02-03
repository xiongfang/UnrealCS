#pragma once

namespace UnrealEngine
{
	class _UHapticFeedbackEffect_Buffer
	{
		static UClass* StaticClass(){return UHapticFeedbackEffect_Buffer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UHapticFeedbackEffect_Buffer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
