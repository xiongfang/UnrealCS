#pragma once

namespace UnrealEngine
{
	class _UBoneMaskFilter
	{
		static UClass* StaticClass(){return UBoneMaskFilter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBoneMaskFilter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
