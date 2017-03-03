#pragma once

namespace UnrealEngine
{
	class _UBoxReflectionCaptureComponent
	{
		static UClass* StaticClass(){return UBoxReflectionCaptureComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBoxReflectionCaptureComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
