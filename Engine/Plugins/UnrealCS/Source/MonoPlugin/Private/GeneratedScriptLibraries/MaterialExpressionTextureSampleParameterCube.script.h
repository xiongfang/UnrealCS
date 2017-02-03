#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureSampleParameterCube
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureSampleParameterCube::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureSampleParameterCube::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
