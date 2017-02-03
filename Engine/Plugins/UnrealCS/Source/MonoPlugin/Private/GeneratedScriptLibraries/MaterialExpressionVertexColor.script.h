#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionVertexColor
	{
		static UClass* StaticClass(){return UMaterialExpressionVertexColor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionVertexColor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
