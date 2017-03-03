#pragma once

namespace UnrealEngine
{
	class _UShapeComponent
	{
		static UClass* StaticClass(){return UShapeComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UShapeComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
