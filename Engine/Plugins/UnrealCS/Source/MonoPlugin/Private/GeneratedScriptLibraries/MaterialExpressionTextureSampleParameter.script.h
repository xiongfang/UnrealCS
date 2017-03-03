#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionTextureSampleParameter
	{
		static UClass* StaticClass(){return UMaterialExpressionTextureSampleParameter::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionTextureSampleParameter::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
