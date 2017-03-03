#pragma once

namespace UnrealEngine
{
	class _USphereReflectionCaptureComponent
	{
		static UClass* StaticClass(){return USphereReflectionCaptureComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USphereReflectionCaptureComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
