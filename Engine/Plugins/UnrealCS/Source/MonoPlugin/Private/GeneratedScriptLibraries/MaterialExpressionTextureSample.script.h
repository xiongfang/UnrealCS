#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureSample
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureSample::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureSample::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
