#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionBlendMaterialAttributes
	{
		static UClass* StaticClass(){return UMaterialExpressionBlendMaterialAttributes::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionBlendMaterialAttributes::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
