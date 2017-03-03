#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionFontSampleParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionFontSampleParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionFontSampleParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
