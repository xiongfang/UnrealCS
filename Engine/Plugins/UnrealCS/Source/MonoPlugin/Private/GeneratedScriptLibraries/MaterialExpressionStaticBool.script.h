#pragma once

namespace UnrealEngine
{
	class _UMaterialExpressionStaticBool
	{
		static UClass* StaticClass(){return UMaterialExpressionStaticBool::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMaterialExpressionStaticBool::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
