#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureSampleParameter2D
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureSampleParameter2D::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureSampleParameter2D::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
