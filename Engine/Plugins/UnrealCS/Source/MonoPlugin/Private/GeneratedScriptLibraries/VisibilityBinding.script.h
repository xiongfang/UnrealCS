#pragma once

namespace UnrealEngine
{
	class _UVisibilityBinding
	{
		static UClass* StaticClass(){return UVisibilityBinding::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UVisibilityBinding::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
