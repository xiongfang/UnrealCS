#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionStaticComponentMaskParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionStaticComponentMaskParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionStaticComponentMaskParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
