#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionMax
	{
		static UClass* StaticClass(){return UMaterialExpressionMax::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionMax::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
