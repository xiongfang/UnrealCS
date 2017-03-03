#pragma once

namespace UnrealEngine
{
	class _UDEPRECATED_PhysicalMaterialPropertyBase
	{
		static UClass* StaticClass(){return UDEPRECATED_PhysicalMaterialPropertyBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDEPRECATED_PhysicalMaterialPropertyBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
