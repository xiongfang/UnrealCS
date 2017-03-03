#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionLinearInterpolate
	{
		static UClass* StaticClass(){return UMaterialExpressionLinearInterpolate::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionLinearInterpolate::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
