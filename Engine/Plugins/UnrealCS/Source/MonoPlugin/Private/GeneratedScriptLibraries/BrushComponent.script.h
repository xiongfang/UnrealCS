#pragma once

namespace UnrealEngine
{
	class _UBrushComponent
	{
		static UClass* StaticClass(){return UBrushComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBrushComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
