#pragma once

namespace UnrealEngine
{
	class _ABrush
	{
		static UClass* StaticClass(){return ABrush::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ABrush::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
