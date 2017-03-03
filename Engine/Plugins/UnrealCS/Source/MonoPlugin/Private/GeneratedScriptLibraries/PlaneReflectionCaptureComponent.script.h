#pragma once

namespace UnrealEngine
{
	class _UPlaneReflectionCaptureComponent
	{
		static UClass* StaticClass(){return UPlaneReflectionCaptureComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPlaneReflectionCaptureComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
