#pragma once

namespace UnrealEngine
{
	class _URecastFilter_UseDefaultArea
	{
		static UClass* StaticClass(){return URecastFilter_UseDefaultArea::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URecastFilter_UseDefaultArea::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
