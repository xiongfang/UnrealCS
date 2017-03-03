#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionConstantBiasScale
	{
		static UClass* StaticClass(){return UMaterialExpressionConstantBiasScale::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionConstantBiasScale::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
