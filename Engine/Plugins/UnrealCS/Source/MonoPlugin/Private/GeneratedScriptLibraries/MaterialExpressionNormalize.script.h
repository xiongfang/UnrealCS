#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionNormalize
	{
		static UClass* StaticClass(){return UMaterialExpressionNormalize::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionNormalize::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
