#pragma once

namespace UnrealEngine
{
	class _UVisual
	{
		static UClass* StaticClass(){return UVisual::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVisual::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
