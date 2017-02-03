#pragma once

namespace UnrealEngine
{
	class _ABrushShape
	{
		static UClass* StaticClass(){return ABrushShape::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ABrushShape::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
