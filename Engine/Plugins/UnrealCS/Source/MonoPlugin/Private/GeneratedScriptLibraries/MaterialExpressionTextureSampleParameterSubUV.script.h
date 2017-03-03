#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureSampleParameterSubUV
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureSampleParameterSubUV::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureSampleParameterSubUV::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
