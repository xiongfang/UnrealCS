#pragma once

namespace UnrealEngine
{
	class _UForceFeedbackAttenuation
	{
		static UClass* StaticClass(){return UForceFeedbackAttenuation::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UForceFeedbackAttenuation::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
