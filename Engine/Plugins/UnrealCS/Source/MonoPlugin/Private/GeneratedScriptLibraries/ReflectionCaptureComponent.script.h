#pragma once

namespace UnrealEngine
{
	class _UReflectionCaptureComponent
	{
		static UClass* StaticClass(){return UReflectionCaptureComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UReflectionCaptureComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
