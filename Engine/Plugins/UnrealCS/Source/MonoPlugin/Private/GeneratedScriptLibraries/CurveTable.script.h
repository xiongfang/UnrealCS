#pragma once

namespace UnrealEngine
{
	class _UCurveTable
	{
		static UClass* StaticClass(){return UCurveTable::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCurveTable::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
