#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionFontSample
	{
		static UClass* StaticClass(){return UMaterialExpressionFontSample::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionFontSample::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
