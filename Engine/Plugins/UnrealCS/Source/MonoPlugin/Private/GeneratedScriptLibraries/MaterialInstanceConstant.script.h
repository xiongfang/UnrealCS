#pragma once

namespace UnrealEngine
{
	class _UMaterialInstanceConstant
	{
		static UClass* StaticClass(){return UMaterialInstanceConstant::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialInstanceConstant::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
