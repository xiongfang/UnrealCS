#pragma once

namespace UnrealEngine
{
	class _UForceFeedbackEffect
	{
		static UClass* StaticClass(){return UForceFeedbackEffect::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UForceFeedbackEffect::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
